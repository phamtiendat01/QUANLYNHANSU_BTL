using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    public int BorderRadius { get; set; } = 15; // Độ bo góc

    public RoundedButton()
    {
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0; // Xóa viền
        this.Font = new Font("Arial", 10, FontStyle.Bold); // Chữ đậm
        this.BackColor = Color.LightBlue; // Màu nền
        this.ForeColor = Color.Black; // Màu chữ
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);
        GraphicsPath path = new GraphicsPath();
        path.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90);
        path.AddArc(Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90);
        path.AddArc(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);
        path.AddArc(0, Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);
        path.CloseFigure();

        this.Region = new Region(path);
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
    }
}
