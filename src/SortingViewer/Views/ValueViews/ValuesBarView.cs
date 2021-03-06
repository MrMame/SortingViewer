using SortingViewer.Model.Data;
using SortingViewer.Model.Data.SortValues;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingViewer.Views.ValueViews {
    public partial class ValuesBarView : UserControl,IValueView
    {

        private ISortValues _Values;
        private ISortValues _initValues = SortValuesFactory.CreateStandardSortValues();

        private Bitmap _drawingBitmap;      // Bitmap for DoubleBuffered Drawing
        private int _padding = 5;           
        private Brush _BackgroundBrush = Brushes.Black;
        private Brush _BarFillBrush = Brushes.Yellow;
        private Brush _BarFillBrushOldShiftIndx = Brushes.Orange;
        private Brush _BarFillBrushNewShiftIndx = Brushes.Red;
        private Brush _BarFillBrushStepMarker = Brushes.White;
        private float stepMarkersHeight = 10;

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
            _drawingBitmap = new Bitmap(this.Size.Width, this.Size.Height);
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
            SetBackgroundInMemoryBuffer(bv, _BackgroundBrush);
            DrawBarsInMemoryBuffer(bv,_Values);
            e.Graphics.DrawImage(_drawingBitmap,0,0);
        }
        #endregion


        #region PRIVATES

        private void DrawBarsInMemoryBuffer(ValuesBarView bv,ISortValues values) {

            int BARSPACE = 2;

            float cntBars = values.Values.Length;
            float barsWidth = ((_drawingBitmap.Width-2*_padding) / cntBars);
            float barsBottomY = _drawingBitmap.Height;
            int barsSpace = 1;
            float BarsHeadHeight = 15;

            // Get the Memory Bitmap for drawing
            Graphics g = Graphics.FromImage(_drawingBitmap);
            // Draw the Bars to the Memory Bitmap
            int cntBar = -1;
            float barsHeight;
            float barsXpos;
            foreach(float val in values.GetValuesNormalized()) {
                cntBar++;
                barsXpos = 0 + _padding + cntBar * barsWidth + BARSPACE;
                barsHeight = val * (bv.Height - 2 * _padding);
                // Select the Brush
                Brush DrawingBrush = _BarFillBrush;
                if(cntBar == _Values.OldIndxOfLastShift) { 
                    DrawingBrush = _BarFillBrushOldShiftIndx; }
                if(cntBar == _Values.NewIndxOfLastShift) { 
                    DrawingBrush = _BarFillBrushNewShiftIndx; }
                // Draw the bar
                g.FillRectangle(DrawingBrush, x: barsXpos, y: barsBottomY-barsHeight - stepMarkersHeight + _padding, width: barsWidth-barsSpace, height: barsHeight - stepMarkersHeight);
                // Seperate Bars Head with a line
                g.DrawLine(Pens.Black, x1: barsXpos, y1: barsBottomY - barsHeight + BarsHeadHeight, x2: barsXpos + barsWidth - barsSpace, y2: barsBottomY - barsHeight + BarsHeadHeight - 2);
                if(cntBar == values.LastCheckedIndx) {
                    // Draw the Step Marker
                    DrawingBrush = _BarFillBrushStepMarker;
                    g.FillRectangle(DrawingBrush, x: barsXpos, y: barsBottomY - stepMarkersHeight, width: barsWidth - barsSpace, height: stepMarkersHeight);
                }

            }
        }

        private void SetBackgroundInMemoryBuffer(ValuesBarView bv, Brush BackgroundBrush) {
            Graphics g = Graphics.FromImage(_drawingBitmap);
            g.FillRectangle(BackgroundBrush, x: 0, y: 0, width: _drawingBitmap.Width, height: _drawingBitmap.Height);                                // Hintergrund Weiss
        }

        private void DrawValues(ISortValues values) {
            _Values = values;
            this.Invalidate();
        }

        #endregion

    }
}
