using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using DrawSharp.Core.Enum;

namespace DrawSharp
{
	public partial class DrawSharp : Form
	{
		private DrawTypes _CurrentTool = DrawTypes.Pencil;
		private Color _CurrentColor { get; set; } = Color.Black;
		private Point _Position { get; set; }
		private Point _PrevPosition { get; set; }
		private float _SelectStroke { get; set; }
		private PencilStrokes _CurrentStrokes { get; set; } = new PencilStrokes();

		public DrawSharp()
		{
			InitializeComponent();
			drawArea.BackgroundImage = new Bitmap(drawArea.Width, drawArea.Height);

			this._Settings();
		}

		private void DrawSharp_Load()
		{
		}

		private void _Settings()
		{
			newSave.Click += (s, e) => {
				using (var dlalog = new SaveFileDialog())
				{
					dlalog.Filter = "jpg files (*.jpg)|*.jpg";
					if (DialogResult.OK == dlalog.ShowDialog())
						drawArea.BackgroundImage.Save(dlalog.FileName);
				}
			};

			closeApp.Click += (s, e) => {
				this.Dispose();
				this.Close();
			};

			colorInfo.Click += (s, e) => {
				using (var dlalog = new ColorDialog())
				{
					if (DialogResult.OK == dlalog.ShowDialog())
						_CurrentColor = dlalog.Color;
				}
			};

			pencil.Click += (s, e) => {
				_CurrentTool = DrawTypes.Pencil;
				status.Text = $"{_CurrentTool} を描画ツールとして設定しました。";
			};

			eraser.Click += (s, e) => {
				_CurrentTool = DrawTypes.Eraser;
				status.Text = $"{_CurrentTool} を描画ツールとして設定しました。";
			};

			fill.Click += (s, e) => {
				_CurrentTool = DrawTypes.Fill;
				status.Text = $"{_CurrentTool} を描画ツールとして設定しました。";
			};

			rect.Click += (s, e) => {
				_CurrentTool = DrawTypes.Rect;
				status.Text = $"{_CurrentTool} を描画ツールとして設定しました。";
			};

			none.Click += (s, e) => {
				_CurrentTool = DrawTypes.None;
				status.Text = $"{_CurrentTool} を描画ツールとして設定しました。";
			};

			L1.Click += (s, e) => 
				_SelectStroke = new PencilStrokes("L1").ReturnPencilStroke();
			L2.Click += (s, e) =>
				_SelectStroke = new PencilStrokes("L2").ReturnPencilStroke();
			L3.Click += (s, e) =>
				_SelectStroke = new PencilStrokes("L3").ReturnPencilStroke();
			L4.Click += (s, e) =>
				_SelectStroke = new PencilStrokes("L4").ReturnPencilStroke();
			L5.Click += (s, e) =>
				_SelectStroke = new PencilStrokes("L5").ReturnPencilStroke();
			L6.Click += (s, e) =>
				_SelectStroke = new PencilStrokes("L6").ReturnPencilStroke();

			// 全消し
			allErase.Click += (s, e) => {
				using (var back = Graphics.FromImage(drawArea.BackgroundImage))
				{
					var front = drawArea.CreateGraphics();
					front.CompositingMode = CompositingMode.SourceCopy;
					front.FillRectangle(Brushes.White, _GenerateRectangle(new Point(drawArea.Width), new Point(drawArea.Height)));
				}
			};
		}

		#region 描画領域でのイベント

		private void drawArea_MouseDown(object sender, MouseEventArgs e)
		{
			_Position = e.Location;
			_PrevPosition = e.Location;
		}

		private void drawArea_MouseUp(object sender, MouseEventArgs e)
		{
			using (var back = Graphics.FromImage(drawArea.BackgroundImage))
			{
				var rect = _GenerateRectangle(_Position, e.Location);
				switch (_CurrentTool)
				{
					case DrawTypes.Fill:
						back.FillRectangle(new SolidBrush(_CurrentColor), rect);
						break;
					case DrawTypes.Rect:
						back.DrawRectangle(new Pen(_CurrentColor), rect);
						break;
				}
			}

			drawArea.Invalidate();
		}

		private void drawArea_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left) return;

			using (var back = Graphics.FromImage(drawArea.BackgroundImage))
			{
				var front = drawArea.CreateGraphics();
				front.CompositingMode = CompositingMode.SourceCopy;

				var prevRect = _GenerateRectangle(_Position, _PrevPosition);
				var rect = _GenerateRectangle(_Position, e.Location);

				switch (_CurrentTool)
				{
					case DrawTypes.Pencil:
						back.DrawLine(new Pen(_CurrentColor, _SelectStroke), _PrevPosition, e.Location);
						front.DrawLine(new Pen(_CurrentColor, _SelectStroke), _PrevPosition, e.Location);
						break;
					case DrawTypes.Eraser:
						back.DrawLine(new Pen(Color.White, _SelectStroke), _PrevPosition, e.Location);
						front.DrawLine(new Pen(Color.Pink, _SelectStroke), _PrevPosition, e.Location);
						break;
					case DrawTypes.Fill:
						front.FillRectangle(Brushes.White, prevRect);
						front.FillRectangle(Brushes.Pink, rect);
						break;
					case DrawTypes.Rect:
						front.DrawRectangle(Pens.White, prevRect);
						front.DrawRectangle(Pens.Pink, rect);
						break;
				}
			}

			_PrevPosition = e.Location;
		}

		#endregion

		///<summary>
		/// 長方形を作成します。
		///</summary>
		private Rectangle _GenerateRectangle(Point p1, Point p2)
		{
			return new Rectangle(Math.Min(p1.X, p2.X), 
				Math.Min(p1.Y, p2.Y), Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y));
		}

	}
}
