﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Puzzle
{
    public partial class Form1 : Form
    {
        private PuzzleStrategy mStrategy;
        private Heuristic mHeuristic;
        private LinearShuffle<int> mShuffle;
        private WindowsFormsSynchronizationContext mSyncContext;
        Dictionary<int, Button> mButtons;
        private int[] mInitialState;
        private bool mBusy;

        public Form1()
        {
            InitializeComponent();
            mSyncContext = SynchronizationContext.Current as WindowsFormsSynchronizationContext;

            Initialize();
        }
        //configuración de juego 
        private void Initialize()
        {
            //mInitialState = new int[] { 15, 14, 11, 9, 8, 10, 13, 12, 7, 2, 4, 6, 3, 1, -1, 5 };
           //mInitialState = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, -1, 15 };
          //  mInitialState = new int[] { 1, 2, 3, 4, 12, 13, 14, 5, 11, -1, 15, 6, 10, 9, 8, 7 };
            mInitialState = new int[] { 1, 2, 3, 4, 12, 13, 14, 5, 11, -1, 15, 6 , 10, 9 ,8, 7 };


            mShuffle = new LinearShuffle<int>();
            mStrategy = new PuzzleStrategy();
            mHeuristic = Heuristic.ManhattanDistance;
            mStrategy.OnStateChanged += OnStrategyStateChanged;
            mStrategy.OnPuzzleSolved += OnPuzzleSolved;

         
            mButtons = new Dictionary<int, Button>();
            mButtons[0] = button1;
            mButtons[1] = button2;
            mButtons[2] = button3;
            mButtons[3] = button4;
            mButtons[4] = button5;
            mButtons[5] = button6;
            mButtons[6] = button7;
            mButtons[7] = button8;
            mButtons[8] = button9;
            mButtons[9] = button10;
            mButtons[10] = button11;
            mButtons[11] = button12;
            mButtons[12] = button13;
            mButtons[13] = button14;
            mButtons[14] = button15;
            mButtons[15] = button16;
     

            // Muestra el estado 
            DisplayState(mInitialState, false);

            statusLabel.Text = "";
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.Visible = false;
            manhattanDistanceMenu.Checked = true;
        }

        private void SwapValues(int x, int y)
        {
            int temp = mInitialState[x];
            mInitialState[x] = mInitialState[y];
            mInitialState[y] = temp;
        }

        private void OnStrategyStateChanged(int[] state, bool isFinal)
        {
            mSyncContext.Post(item => DisplayState(state, isFinal), null);
            Thread.Sleep(1000);
        }
        //calcula la solucion posible 
        private void OnPuzzleSolved(int steps, int time, int statesExamined)
        {
            Action action = () =>
                {
                    progressBar.Visible = false;
                    this.Cursor = Cursors.Default;

                    if (steps > -1)
                    {
                        statusLabel.Text = "Pasos: " + steps.ToString("n0") + ", Tiempo: " + (time / 1500.0).ToString("n2") + ", Estados: " + statesExamined.ToString("n0");
                        MessageBox.Show(this, "Se tiene una solucion...");
                    }
                    else
                    {
                        statusLabel.Text = "Pasos: none, Tiempo: " + (time / 1500.0).ToString("n3") + "sec, Estados: " + statesExamined.ToString("n0");
                        MessageBox.Show(this, "Sin solución!");
                    }
                };

            mSyncContext.Send(item => action.Invoke(), null);
        }

        private void DisplayState(int[] nodes, bool isFinal)
        {
            if (nodes != null)
            {
                this.gamePanel.SuspendLayout();

                for (int i = 0; i < nodes.Length; i++)
                {
                    if (nodes[i] > 0)
                    {
                        mButtons[i].Text = nodes[i].ToString();
                    }
                    else
                    {
                        mButtons[i].Text = null;
                    }
                }

                this.gamePanel.ResumeLayout();
            }

            if (isFinal)
            {
                mBusy = false;
                buttonShuffle.Enabled = true;
                buttonStart.Enabled = true;
            }
        }

        private void StartSolvingPuzzle()
        {
            mStrategy.Solve(mInitialState, mHeuristic);

            progressBar.Visible = true;
            this.Cursor = Cursors.WaitCursor;
            statusLabel.Text = "Calculando Solución";
            mBusy = true;
        }

        private bool ActionAllowed()
        {
            return !mBusy;
        }

        private void ShuffleButton_Click(object sender, EventArgs e)
        {
            if (ActionAllowed())
            {
                mShuffle.Shuffle(mInitialState);
           
                DisplayState(mInitialState, false);
            }
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (ActionAllowed())
            {
                Button button = sender as Button;

                if (button != null && button.Tag != null)
                {
                    int value;
                    Button tileButton;

                    if (int.TryParse(button.Tag.ToString(), out value) && mButtons.TryGetValue(value, out tileButton) && button == tileButton)
                    {
                        button.DoDragDrop(button.Tag, DragDropEffects.Copy | DragDropEffects.Move);
                    }
                }
            }
        }

        private void Button_DragEnter(object sender, DragEventArgs e)
        {
            if (ActionAllowed())
            {
                if (e.Data.GetDataPresent(DataFormats.Text))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        private void Button_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (ActionAllowed())
            {
                Button button = sender as Button;
                if (button != null && button.Tag != null)
                {
                    int dropValue;
                    Button buttonToDrop;

                    if (int.TryParse(button.Tag.ToString(), out dropValue) && mButtons.TryGetValue(dropValue, out buttonToDrop) && button == buttonToDrop)
                    {
                        int dragValue;

                        if (int.TryParse(e.Data.GetData(DataFormats.Text).ToString(), out dragValue) && dropValue != dragValue)
                        {
                            SwapValues(dragValue, dropValue);
                            DisplayState(mInitialState, false);
                        }
                    }
                }
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (ActionAllowed())
            {
                StartSolvingPuzzle();
            }
        }

        private void ShuffleMenu_Click(object sender, EventArgs e)
        {
            if (ActionAllowed())
            {
                mShuffle.Shuffle(mInitialState);
               
                DisplayState(mInitialState, false);
            }
        }

        private void SolveMenu_Click(object sender, EventArgs e)
        {
            if (ActionAllowed())
            {
                StartSolvingPuzzle();
            }
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManhattanDistanceMenu_Click(object sender, EventArgs e)
        {
            if (ActionAllowed())
            {
                mHeuristic = Heuristic.ManhattanDistance;
                manhattanDistanceMenu.Checked = true;
                misplacedTilesMenu.Checked = false;
            }
        }

        private void MisplacedTilesMenu_Click(object sender, EventArgs e)
        {
            if (ActionAllowed())
            {
                mHeuristic = Heuristic.MisplacedTiles;
                misplacedTilesMenu.Checked = true;
                manhattanDistanceMenu.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
