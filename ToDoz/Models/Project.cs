using System;
using System.Drawing;

namespace ToDoz.Models
{
    public class Project
    {

        // Project Name
        public Image ProjectImage { get; set; }

        // Project Name
        public string ProjectName { get; set; }

        // Project Date
        public DateTime Created { get; set; }

        // Project Leader Name
        public virtual ApplicationUser ProjectLeader { get; set; }

        // Sub Process of the Project
        public SubProcess[] SubProcesses { get; set; }


        // Draws a Box with Project Name in the Center
        public Image DrawProjectBox(string ProjectName)
        {
            int Width = 512;
            int Hight = 512;
            Point MidPoint = new Point(Width/2, Hight/2);
            Size RectSize = new Size(100, 50);

            Image image = new Bitmap(Width, Hight);

            Graphics graph = Graphics.FromImage(image);

            Rectangle rectangle = new Rectangle(MidPoint, RectSize);

            Font font = new Font(FontFamily.GenericMonospace,20);
            Brush brush = new SolidBrush(Color.Black);


            graph.Clear(Color.Azure);
          
            Pen pen = new Pen(Brushes.Black);

            graph.DrawRectangle(pen, rectangle);
            graph.DrawString(ProjectName,font, brush, rectangle);

            // graph.DrawLines(pen, new Point[] { MidPoint, new Point(800, 900) });

            graph.DrawString("Project Name",
            new Font(new FontFamily("DecoType Thuluth"), 20, FontStyle.Bold),
            Brushes.Blue, new PointF(150, 90));

            image.Save("graph.jpeg", System.Drawing.Imaging.ImageFormat.Png);

            return image;

        }

    }
}
