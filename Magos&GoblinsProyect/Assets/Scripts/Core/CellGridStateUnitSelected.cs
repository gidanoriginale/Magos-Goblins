﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;


class CellGridStateUnitSelected : CellGridState
{
    public Unit _unit;
    private List<Cell> _pathsInRange;
    private List<Unit> _unitsInRange;

    private Cell _unitCell;

    public CellGridStateUnitSelected(CellGrid cellGrid, Unit unit) : base(cellGrid)
    {
        _unit = unit;
        _pathsInRange = new List<Cell>();
        _unitsInRange = new List<Unit>();
    }

	//Esto hace que se mueva
    public override void OnCellClicked(Cell cell)
    {
        if (_unit.isMoving)
            return;
        if(cell.IsTaken)
        {
            _cellGrid.CellGridState = new CellGridStateWaitingForInput(_cellGrid);
            return;
        }
            
        if(!_pathsInRange.Contains(cell))
        {
            _cellGrid.CellGridState = new CellGridStateWaitingForInput(_cellGrid);
        }
        else
        {
			if (!_unit.unitAttack && _unit.moveOn) {
				var path = _unit.FindPath(_cellGrid.Cells, cell);
				_unit.Move(cell,path);
				_cellGrid.CellGridState = new CellGridStateUnitSelected(_cellGrid, _unit);
			}
        }
    }
	//Esto hace que ataque o cambie el personaje seleccionado
    public override void OnUnitClicked(Unit unit)
    {

		if (unit.Equals (_unit) || unit.isMoving) {
			return;
		}
		//Aqui hace el ataque: mira si dos unidades (la actual seleccionada y la nueva)
		//son distintas, y por lo tanto hace el ataque si dispone de puntos de acción suficientes.
        if (_unitsInRange.Contains(unit) && _unit.ActionPoints > 0)
        {
            _unit.DealDamage(unit);
            _cellGrid.CellGridState = new CellGridStateUnitSelected(_cellGrid, _unit);
        }

        if (unit.PlayerNumber.Equals(_unit.PlayerNumber))
        {
            _cellGrid.CellGridState = new CellGridStateUnitSelected(_cellGrid, unit);
        }
            
    }
    public override void OnCellDeselected(Cell cell)
    {
        base.OnCellDeselected(cell);
		if (!_unit.unitAttack && _unit.moveOn) {
			foreach (var _cell in _pathsInRange) {
				_cell.MarkAsReachable ();
			}
		
			foreach (var _cell in _cellGrid.Cells.Except(_pathsInRange)) {
				_cell.UnMark ();
			}
		}
    }
    public override void OnCellSelected(Cell cell)
    {

        base.OnCellSelected(cell);
        if (!_pathsInRange.Contains(cell)) return;
        var path = _unit.FindPath(_cellGrid.Cells, cell);
		if (!_unit.unitAttack && _unit.moveOn) {
			foreach (var _cell in path)
			{
				_cell.MarkAsPath();
			}
		}
    }

    public override void OnStateEnter()
    {
        base.OnStateEnter();

        _unit.OnUnitSelected();
        _unitCell = _unit.Cell;

        _pathsInRange = _unit.GetAvailableDestinations(_cellGrid.Cells);
        var cellsNotInRange = _cellGrid.Cells.Except(_pathsInRange);

		if (!_unit.unitAttack && _unit.moveOn) {
			foreach (var cell in cellsNotInRange)
			{
				cell.UnMark();
			}
			foreach (var cell in _pathsInRange)
			{
				cell.MarkAsReachable();
			}
		}


        if (_unit.ActionPoints <= 0) return;

        foreach (var currentUnit in _cellGrid.Units)
        {
            if (currentUnit.PlayerNumber.Equals(_unit.PlayerNumber))
                continue;
        
            if (_unit.IsUnitAttackable(currentUnit,_unit.Cell))
            {
                currentUnit.SetState(new UnitStateMarkedAsReachableEnemy(currentUnit));
                _unitsInRange.Add(currentUnit);
            }
        }
        
        if (_unitCell.GetNeighbours(_cellGrid.Cells).FindAll(c => c.MovementCost <= _unit.MovementPoints).Count == 0 
            && _unitsInRange.Count == 0)
            _unit.SetState(new UnitStateMarkedAsFinished(_unit));
    }
    public override void OnStateExit()
    {
        _unit.OnUnitDeselected();
		_unit.unitAttack = false;
		_unit.moveOn = false;
        foreach (var unit in _unitsInRange)
        {
            if (unit == null) continue;
            unit.SetState(new UnitStateNormal(unit));
        }
        foreach (var cell in _cellGrid.Cells)
        {
            cell.UnMark();
        }   
    }
}

