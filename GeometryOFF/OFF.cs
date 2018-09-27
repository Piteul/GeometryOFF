using System;
using System.IO;

namespace GeometryOFF {
    class OFF {

        public int height;
        public int width;
        public int[,] r;
        public int[,] g;
        public int[,] b;


        public OFF(int _height, int _width) {
            height = _height;
            width = _width;
            r = new int[height, width];
            g = new int[height, width];
            b = new int[height, width];

            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++) {
                    r[i, j] = 255;
                    g[i, j] = 255;
                    b[i, j] = 255;
                }
        }

        OFF off = new OFF(2,2);

        public static void writePPM(string fileOFF, OFF fileOFFOFF) {
            //Use a streamwriter to write the text part of the encoding.
            var width = fileOFF.width;
            var height = fileOFF.height;

            // Set a variable to the My Documents path.
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //string mydocpath = "C:\\Users\\atetart\\Documents";


            StreamWriter outputFile = new StreamWriter(Path.Combine(mydocpath, fileOFF));
            outputFile.Write("P3" + "\n");
            outputFile.Write(width + " " + height + "\n");
            outputFile.Write("255" + "\n");


            for (int x = 0; x < height; x++)
                for (int y = 0; y < width; y++) {
                    outputFile.WriteLine(fileOFF.r[x, y]);
                    outputFile.WriteLine(fileOFF.g[x, y]);
                    outputFile.WriteLine(fileOFF.b[x, y]);
                }
            outputFile.Close();
        }

        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }
    }
}
