using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace KTNESolver_2.Forms
{
    public partial class MazeForm : Form
    {

        Image dot = Properties.Resources.dot1;
        Image circle = Properties.Resources.dot_Circle;
        Image endpoint = Properties.Resources.Endpoint;

        ButtonState[] buttonState = new ButtonState[36];
        Dictionary<ButtonState, Image> srcLookup = new Dictionary<ButtonState, Image>();
        Button[] buttons;
        PictureBox[] cells;

        List<int[]> mazePointIdentifier = new List<int[]>();

        List<Dictionary<int, Dictionary<int, int>>> solution = new List<Dictionary<int, Dictionary<int, int>>>();
        List<Bitmap> mazeLayouts = new List<Bitmap>();

        public MazeForm()
        {
            InitializeComponent();

            buttons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32, button33, button34, button35, button36 };
            cells = new PictureBox[] { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25, pictureBox26, pictureBox27, pictureBox28, pictureBox29, pictureBox30, pictureBox31, pictureBox32, pictureBox33, pictureBox34, pictureBox35, pictureBox36, pictureBox37 };
            for (int i = 0; i < 36; ++i)
            {
                buttonState[i] = ButtonState.dot;
            }
            srcLookup.Add(ButtonState.dot, dot);
            srcLookup.Add(ButtonState.circle, circle);
            srcLookup.Add(ButtonState.endpoint, endpoint);

            mazePointIdentifier.Add(new int[2] { 6, 17 });  // Maze 1 
            mazeLayouts.Add(Properties.Resources.maze0);

            mazePointIdentifier.Add(new int[2] { 10, 19 });  // Maze 2
            mazeLayouts.Add(Properties.Resources.maze1);

            mazePointIdentifier.Add(new int[2] { 21, 23 });  // Maze 3
            mazeLayouts.Add(Properties.Resources.maze2);

            mazePointIdentifier.Add(new int[2] { 0, 18 });  // Maze 4
            mazeLayouts.Add(Properties.Resources.maze3);

            mazePointIdentifier.Add(new int[2] { 16, 33 });  // Maze 5
            mazeLayouts.Add(Properties.Resources.maze4);

            mazePointIdentifier.Add(new int[2] { 4, 26 });  // Maze 6
            mazeLayouts.Add(Properties.Resources.maze5);

            mazePointIdentifier.Add(new int[2] { 1, 31 });  // Maze 7
            mazeLayouts.Add(Properties.Resources.maze6);

            mazePointIdentifier.Add(new int[2] { 3, 20 });  // Maze 8
            mazeLayouts.Add(Properties.Resources.maze7);

            mazePointIdentifier.Add(new int[2] { 8, 24 });  // Maze 9
            mazeLayouts.Add(Properties.Resources.maze8);

            loadSolutions();

        }

        private void loadSolutions()
        {
            for (int mazeID = 0; mazeID < 9; ++mazeID)
            {
                Dictionary<int, Dictionary<int, int>> currentMaze = new Dictionary<int, Dictionary<int, int>>();
                for (int startingpointSolution = 0; startingpointSolution < 36; ++startingpointSolution)
                {
                    Dictionary<int, int> currentStartingPointMap = new Dictionary<int, int>();

                    string dir = "KTNESolver_2.resource.Maze.solution.maze" + mazeID + ".m" + mazeID + "s" + startingpointSolution + ".txt";

                    var assembly = Assembly.GetExecutingAssembly();
                    using (Stream stream = assembly.GetManifestResourceStream(dir))
                    using (StreamReader reader = new StreamReader(stream))
                    {

                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] parts = line.Split(";");
                            currentStartingPointMap.Add(Convert.ToInt32(parts[0]), Convert.ToInt32(parts[1]));
                        }
                        currentMaze.Add(startingpointSolution, currentStartingPointMap);
                    }
                }
                solution.Add(currentMaze);
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

            Button btn = sender as Button ?? new Button();
            int index = Array.IndexOf(buttons, btn);

            if (index == -1) { return; }

            ButtonState currState = buttonState[index];

            switch (currState)
            {
                case ButtonState.dot:
                    buttonState[index] = ButtonState.circle;
                    break;
                case ButtonState.circle:
                    buttonState[index] = ButtonState.endpoint;
                    break;
                case ButtonState.endpoint:
                    buttonState[index] = ButtonState.dot;
                    break;
            }

            btn.BackgroundImage = srcLookup[buttonState[index]];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();

            for (int i = 0; i < 36; ++i)
            {
                if (buttonState[i] == ButtonState.circle)
                {
                    ids.Add(i);
                }
            }


            if(ids.Count != 2) { return; }

            int foundID = -1;

            foreach (int[] mazeIds in mazePointIdentifier)
            {
                if (mazeIds[0] == ids[0] && mazeIds[1] == ids[1])
                {
                    foundID = mazePointIdentifier.IndexOf(mazeIds);
                }
            }

            List<int> endpoints = new List<int>();

            for (int i = 0; i < 36; ++i)
            {
                if (buttonState[i] == ButtonState.endpoint)
                {
                    endpoints.Add(i);
                }
            }

            if (endpoints.Count != 2) { return; }

            int from = endpoints[0];
            int to = endpoints[1];

            var maze = solution[foundID];

            var startingPointSolution = maze[from];

            List<int> solutionPath = new List<int>();

            solutionPath.Add(to);

            while (!solutionPath.Contains(from))
            {
                solutionPath.Add(startingPointSolution[solutionPath[solutionPath.Count - 1]]);
            }

            tableLayout.BackgroundImage = mazeLayouts[foundID];
            foreach (IntegerProperty i in solutionPath)
            {
                cells[(int)i].BackgroundImage = endpoint;
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {    
            for(int i = 0; i < 36; ++i)
            {
                buttonState[i] = ButtonState.dot;
                buttons[i].BackgroundImage = dot;
            }

            tableLayout.BackgroundImage = null;
            foreach(PictureBox c in cells)
            {
                c.BackgroundImage = null;
            }
        }
    }

    enum ButtonState
    {
        dot,
        circle,
        endpoint
    }

    
}
