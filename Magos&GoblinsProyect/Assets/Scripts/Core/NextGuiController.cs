﻿using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextGuiController : MonoBehaviour
{
    public CellGrid CellGrid;
    public GameObject UnitsParent;

    public Button NextTurnButton;

    public GameObject InfoPanel;
    public GameObject GameOverPanel;
    public Canvas Canvas;

    private GameObject _infoPanel;
    private GameObject _gameOverPanel;

    void Start()
    {
        CellGrid.GameStarted += OnGameStarted;
//        CellGrid.TurnEnded += OnTurnEnded;
//        CellGrid.GameEnded += OnGameEnded;
    }

    private void OnGameStarted(object sender, EventArgs e)
    {
        foreach (Transform unit in UnitsParent.transform)
        {
            unit.GetComponent<Unit>().UnitHighlighted += OnUnitHighlighted;
            unit.GetComponent<Unit>().UnitDehighlighted += OnUnitDehighlighted;
            unit.GetComponent<Unit>().UnitDestroyed += OnUnitDestroyed;
            unit.GetComponent<Unit>().UnitAttacked += OnUnitAttacked;
        }
    }

    private void OnUnitAttacked(object sender, AttackEventArgs e)
    {
        if (!(CellGrid.CurrentPlayer is HumanPlayer)) return;

        OnUnitDehighlighted(sender, e);

        if ((sender as Unit).HitPoints <= 0) return;

        OnUnitHighlighted(sender, e);
    }
    private void OnUnitDestroyed(object sender, AttackEventArgs e)
    {
        Destroy(_infoPanel);
    }
    private void OnUnitDehighlighted(object sender, EventArgs e)
    {
        Destroy(_infoPanel);
    }
    private void OnUnitHighlighted(object sender, EventArgs e)
    {
        var unit = sender as GenericUnit;
        _infoPanel = Instantiate(InfoPanel);

        float hpScale = (float)((float)(unit).HitPoints / (float)(unit).TotalHitPoints);

        _infoPanel.transform.Find("Name").GetComponent<Text>().text = unit.UnitName;
        _infoPanel.transform.Find("HitPoints").Find("Image").transform.localScale = new Vector3(hpScale,1,1);


        _infoPanel.GetComponent<RectTransform>().SetParent(Canvas.GetComponent<RectTransform>(),false);
    }

	void OnGUI () {

		if(GUI.Button(new Rect(20, 10, 100, 50),"End Turn")){

			CellGrid.EndTurn();
		}
	}
}

