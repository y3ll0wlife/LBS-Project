using maze_solver.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace maze_solver
{
    public partial class Form1 : Form
    {
        public  Form1()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Handlers.Form1_KeyDown);    
        }
        public class Pice
        {
            public int XCord { get; set; }
            public int YCord { get; set; }
            public Button Btn { get; set; }
        }

        public static class GameManger
        {
            public static bool uploadOwnMaze = false;
            public static bool solutionFound = false;
            public static string mazeFile;
            public static Button currentHoverBtn;
            public static Button startBtn;
            public static Button endBtn;

            // x, y, stance
            // stance 0 = nothing
            // stance 1 = wall
            // stance 2 = start
            // stance 3 = end
            public static List<Pice> board = new List<Pice>();
        }

        
        public static class Config
        {
            public static int BUTTON_SIZE = 50;
            public static Color WALL_COLOR = Color.Red;
            public static Color START_COLOR = Color.Green;
            public static Color END_COLOR = Color.Blue;
            public static Color PATH_COLOR = Color.Orange;
        }


        private void GenerateBoard(int x, int y)
        {
            int BUTTON_SIZE = Config.BUTTON_SIZE;
            int SKIP_Y = 50;
            Height = (y + 1) * BUTTON_SIZE + SKIP_Y;
            Width = (x + 1) * BUTTON_SIZE;

            if (GameManger.uploadOwnMaze)
            {
                string[] lines = GameManger.mazeFile.Split( new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None );
                for (int i = 0; i < y; i++)
                {
                    for (int ii = 0; ii < x; ii++)
                    {
                        
                        Color color = Color.Transparent;
                        Button btn = new Button();

                        if (lines[i][ii] == '1')
                        {
                            color = Config.WALL_COLOR;
                        }
                        else if (lines[i][ii] == '2')
                        {
                            GameManger.startBtn = btn;
                            color = Config.START_COLOR;
                        }
                        else if (lines[i][ii] == '3')
                        {
                            GameManger.endBtn = btn;
                            color = Config.END_COLOR;
                        }

                        GameManger.board.Add(new Pice()
                        {
                            Btn = btn,
                            XCord = ii,
                            YCord = i,
                        });


                        Controls.Add(btn);
                       // btn.Text = $"{ii}, {i}";
                        btn.Location = new Point(ii * BUTTON_SIZE, i * BUTTON_SIZE + SKIP_Y);
                        btn.Size = new Size(BUTTON_SIZE, BUTTON_SIZE);
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.BackColor = color;
                        btn.Click += new EventHandler(Handlers.Handle_click);
                        btn.MouseHover += new EventHandler(Handlers.Handle_hover);
                    }
                }

            }
            
            else
            {
                
                for (int i = 0; i < y; i++)
                {
                    for (int ii = 0; ii < x; ii++)
                    {
                        Button btn = new Button();
                        Controls.Add(btn);
                        btn.Text = $"{ii}, {i}";
                        btn.Location = new Point(ii * BUTTON_SIZE, i * BUTTON_SIZE + SKIP_Y);
                        btn.Size = new Size(BUTTON_SIZE, BUTTON_SIZE);
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.Click += new EventHandler(Handlers.Handle_click);
                        btn.MouseHover += new EventHandler(Handlers.Handle_hover);

                        GameManger.board.Add(new Pice()
                        {
                            Btn = btn,
                            XCord = ii,
                            YCord = i,
                        });
                    }
                }
            }
        }

       
        private void startProgram_Click(object sender, EventArgs e)
        {
            SetupBoard();
            GenerateBoard(Convert.ToInt32(Math.Round(mazeLayoutX.Value, 0)), 
                Convert.ToInt32(Math.Round(mazeLayoutY.Value, 0)));
        }

        private void SetupBoard()
        {
            labelLayoutX.Visible = false;
            labelLayoutY.Visible = false;

            mazeLayoutX.Visible = false;
            mazeLayoutY.Visible = false;

            uploadMaze.Visible = false;
            startProgram.Visible = false;

            exportMaze.Visible = true;
            solveMaze.Visible = true;
        }

        private void uploadMaze_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Text files | *.txt",
                Multiselect = false
            };
            if (dialog.ShowDialog() == DialogResult.OK) 
            {
                string path = dialog.FileName; 
                string file = new StreamReader(path).ReadToEnd();
                GameManger.mazeFile = file;
                string[] lines = file.Split(new char[] { '\n' });       
                mazeLayoutX.Value = lines[0].Length -1;
                mazeLayoutY.Value = lines.Length - 1;

                GameManger.uploadOwnMaze = true;
            }
        }

        private void exportMaze_Click(object sender, EventArgs e)
        {
            long timeStamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            string fileName = $"maze-{timeStamp}.txt";
            StreamWriter w = new StreamWriter($"../../{fileName}");
            bool first = true;

            foreach (Pice pice in GameManger.board)
            {
                int value = 0;
                if (pice.XCord % mazeLayoutX.Value == 0 && !first) w.WriteLine("");
                if (pice.Btn.BackColor == Config.WALL_COLOR) value = 1;
                else if (pice.Btn.BackColor == Config.START_COLOR) value = 2;
                else if (pice.Btn.BackColor == Config.END_COLOR) value = 3;
                w.Write(value);
                first = false;
            }
            w.Close();
            MessageBox.Show("Exported maze");
        }

        private void solveMaze_Click(object sender, EventArgs e)
        {
           
            int[,] boardArr = new int[15, 15];
            int x = 0;
            int y = 0;
            int xStart = 0;
            int yStart = 0;
            int xEnd = 0;
            int yEnd = 0;
            bool first2 = true;
            foreach (Pice pice in GameManger.board)
            {
                int value = 0;
                if (pice.XCord % mazeLayoutX.Value == 0 && !first2)
                {
                    y++;
                    x = 0;
                }
                if (pice.Btn.BackColor == Config.WALL_COLOR) value = 1;
                else if (pice.Btn.BackColor == Config.START_COLOR)
                {
                    value = 2;
                    xStart = x;
                    yStart = y;
                    int xCurrent = x;
                    int yCurrent = y;
                }
                else if (pice.Btn.BackColor == Config.END_COLOR)
                {
                    value = 3;
                    xEnd = x;
                    yEnd = y;
                }

                boardArr[x, y] = value;
                first2 = false;
                x++;
            }

         
            for (int i = 0; i < boardArr.GetLength(0); i++)
            {
                for (int j = 0; j < boardArr.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", boardArr[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }

            MessageBox.Show("Starting to solve the maze");

            solveMazeMain(boardArr, xStart, yStart, xEnd, yEnd);

        }

        private void GenerateBoardSolution(int[,] sol, int x, int y)
        {
            int BUTTON_SIZE = Config.BUTTON_SIZE;
            int SKIP_Y = 50;
            Height = (y + 1) * BUTTON_SIZE + SKIP_Y;
            Width = (x + 1) * BUTTON_SIZE;

            for (int i = 0; i < y; i++)
            {
                for (int ii = 0; ii < x; ii++)
                {
                    Color color = Color.Transparent;
                   
                    if (sol[ii, i] == 1 ) color = Config.WALL_COLOR;
                    else if (sol[ii, i] == 2) color = Config.START_COLOR;  
                    else if (sol[ii, i] == 3) color = Config.END_COLOR;   
                    else if (sol[ii, i] == 5) color = Config.PATH_COLOR;
                    

                    Button btn = new Button();
                    Controls.Add(btn);
                   // btn.Text = $"{ii}, {i}";
                    btn.Location = new Point(ii * BUTTON_SIZE, i * BUTTON_SIZE + SKIP_Y);
                    btn.Size = new Size(BUTTON_SIZE, BUTTON_SIZE);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = color;
                    btn.Click += new EventHandler(Handlers.Handle_click);
                    btn.MouseHover += new EventHandler(Handlers.Handle_hover); 
                }
            }
        }
   



        bool solveMazeMain(int[,] maze, int xStart, int yStart, int xEnd, int yEnd)
        {
            int[,] sol = new int[15, 15];

            if (solveMazeUtil(maze, xStart, yStart, xEnd, yEnd, sol) == false)
            {
                MessageBox.Show("Solution doesn't exist");
                return false;
            }

           // Console.WriteLine(sol);

            foreach (var btn in Controls.OfType<Button>())
                btn.Hide();

            GenerateBoardSolution(sol, 15, 15);
           

           // MessageBox.Show("Solution found");
            return true;
        }

        bool isSafe(int[,] maze, int x, int y)
        {
            int N = 15;
            if (x >= N || y >= N || y < 0 || x < 0) return false;
            //MessageBox.Show($"{y}, {x}: Value: {maze[x, y].ToString()}");
           
            return maze[x, y] == 2 || maze[x, y] == 3 || maze[x, y] == 0;
        }
       


        bool solveMazeUtil(int[,] maze, int x, int y, int xEnd, int yEnd, int[,] sol)
        {
            if (x == xEnd && y == yEnd )
            {
                sol[x, y] = 3;
                return true;
            }

          
            if (isSafe(maze, x, y) == true)
            {
                sol[x, y] = 5;

              
                if (solveMazeUtil(maze, x + 1, y, xEnd, yEnd, sol)) return true;
                else if (solveMazeUtil(maze, x , y + 1, xEnd, yEnd, sol)) return true;
                else if (solveMazeUtil(maze, x, y - 1, xEnd, yEnd, sol)) return true;
                // else if (solveMazeUtil(maze, x - 1, y, xEnd, yEnd, sol)) return true;

                return false;
            }
           



                return false;
        }
    }
}
