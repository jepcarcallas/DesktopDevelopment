using System.Drawing;

namespace Exercise2
{
    internal static class Properties
    {
        internal static class Resources
        {
            private static Bitmap? _add;
            private static Bitmap? _edit;
            private static Bitmap? _delete;
            private static Bitmap? _save;
            private static Bitmap? _open;

            public static Bitmap add
            {
                get
                {
                    if (_add == null)
                    {
                        _add = CreateIcon("+", Color.FromArgb(34, 139, 34));
                    }
                    return _add;
                }
            }

            public static Bitmap edit
            {
                get
                {
                    if (_edit == null)
                    {
                        _edit = CreateIcon("?", Color.FromArgb(30, 144, 255));
                    }
                    return _edit;
                }
            }

            public static Bitmap delete
            {
                get
                {
                    if (_delete == null)
                    {
                        _delete = CreateIcon("×", Color.FromArgb(220, 20, 60));
                    }
                    return _delete;
                }
            }

            public static Bitmap save
            {
                get
                {
                    if (_save == null)
                    {
                        _save = CreateIcon("??", Color.FromArgb(70, 130, 180));
                    }
                    return _save;
                }
            }

            public static Bitmap open
            {
                get
                {
                    if (_open == null)
                    {
                        _open = CreateIcon("??", Color.FromArgb(255, 140, 0));
                    }
                    return _open;
                }
            }

            private static Bitmap CreateIcon(string text, Color backgroundColor)
            {
                Bitmap bmp = new Bitmap(16, 16);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.Transparent);
                    using (SolidBrush brush = new SolidBrush(backgroundColor))
                    {
                        g.FillRectangle(brush, 0, 0, 16, 16);
                    }
                    using (Font font = new Font("Segoe UI", 10, FontStyle.Bold))
                    using (SolidBrush textBrush = new SolidBrush(Color.White))
                    {
                        StringFormat sf = new StringFormat
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center
                        };
                        g.DrawString(text, font, textBrush, new RectangleF(0, 0, 16, 16), sf);
                    }
                }
                return bmp;
            }
        }
    }
}
