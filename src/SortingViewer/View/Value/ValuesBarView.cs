﻿using SortingViewer.Model.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingViewer.View.Value
{
    public partial class ValuesBarView : UserControl,IValueView
    {

        private ISortValues _Values;
        private ISortValues _initValues = new SortValues(10,25,40,25,1,12,40,34,50,23,33,72,37,42,13,25,6,95,100);

        private int _padding = 5;
        private Brush _BackgroundBrush = Brushes.Black;
        private Brush _BarFillBrush = Brushes.Yellow;



        #region PROPERTIES
        /// <summary>
        /// Padding space between Bars and the canvas borders
        /// </summary>
        public int BarsPadding {
            get { return _padding; }
            set { _padding = value; }
        }
        #endregion



        #region INTERFACE: IValueView
        /// <summary>
        /// Shows the Values as a bar diagramm on the canvas
        /// </summary>
        /// <param name="Values">Values int[] to show at the canvas</param>
        public void ShowValues(ISortValues Values){
            DrawValues(Values);
        }
        /// <summary>
        /// Clear all Data from view and Show a blank canvas
        /// </summary>
        public void ResetView(){
            _Values = new SortValues();
        }
        #endregion



        #region PUBLICS
        /// <summary>
        /// Constructor
        /// </summary>
        public ValuesBarView(){
            InitializeComponent();
            _Values = _initValues;
        }
        #endregion



        #region EVENT-HANDLER
        /// <summary>
        /// If the Control gets Resized, it is not sure that the paint event gets also fired.
        /// To ensure that the Value Bars Graphics are always fitting when the form size is changing,
        /// we call the paint event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValuesBarView_Resize(object sender, EventArgs e) {
            this.Refresh();
        }
        /// <summary>
        /// The Event Draws all values Bars inside the control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValuesBarView_Paint(object sender, PaintEventArgs e){
            // Get Grafics Objekt from the Control to draw
            var bv = (ValuesBarView)sender;
            Graphics g = bv.CreateGraphics();
            // RefreshBackground
            SetBackground(bv, _BackgroundBrush);
            DrawBars(bv,_BarFillBrush, _Values);
            //g.DrawLine(Pens.Black, new Point(0, 0), new Point(  bv.Width, bv.Height));      // Zeichne eine Testlinie
        }
        #endregion


        #region PRIVATES

        private void DrawBars(ValuesBarView bv, Brush BarBrush, ISortValues values) {
            float cntBars = values.Values.Length;
            float barsWidth = (bv.Width-2*_padding) / cntBars;
            float barsBottomY = 0;

            Graphics g = bv.CreateGraphics();
            int cntBar = -1;
            foreach(float val in values.GetValuesNormalized()) {
                cntBar++;
                float barsXpos = 0 + _padding + cntBar * barsWidth;
                g.FillRectangle(BarBrush, x: barsXpos, y: barsBottomY+_padding, width: barsWidth, height: val*(bv.Height-2*_padding));

            }

        }

        private void SetBackground(ValuesBarView bv, Brush BackgroundBrush) {
            Graphics g = bv.CreateGraphics();
            g.FillRectangle(BackgroundBrush, x: 0, y: 0, width: bv.Width, height: bv.Height);                                // Hintergrund Weiss
        }

        private void DrawValues(ISortValues values) {
            _Values = values;
            this.Invalidate();
        }

        #endregion

    }
}