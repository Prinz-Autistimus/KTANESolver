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

        List<int[]> mazePointIdentifier = new List<int[]>();

        public MazeForm()
        {
            InitializeComponent();

            buttons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32, button33, button34, button35, button36 };
            for (int i = 0; i < 36; ++i)
            {
                buttonState[i] = ButtonState.dot;
            }
            srcLookup.Add(ButtonState.dot, dot);
            srcLookup.Add(ButtonState.circle, circle);
            srcLookup.Add(ButtonState.endpoint, endpoint);

            mazePointIdentifier.Add(new int[2] { 6 , 17 });  // Maze 1 
            mazePointIdentifier.Add(new int[2] { 10, 19 });  // Maze 2
            mazePointIdentifier.Add(new int[2] { 21, 23 });  // Maze 3

            mazePointIdentifier.Add(new int[2] { 0 , 18 });  // Maze 4
            mazePointIdentifier.Add(new int[2] { 16, 33 });  // Maze 5
            mazePointIdentifier.Add(new int[2] { 4 , 26 });  // Maze 6

            mazePointIdentifier.Add(new int[2] { 1 , 31 });  // Maze 7
            mazePointIdentifier.Add(new int[2] { 3 , 20 });  // Maze 8
            mazePointIdentifier.Add(new int[2] { 8 , 24 });  // Maze 9


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
            int[] ids = new int[2];
            int idIndex = 0;

            for (int i = 0; i < 36; ++i)
            {
                if (buttonState[i] == ButtonState.circle)
                {
                    ids[idIndex++] = i;
                }
            }

            foreach (int[] mazeIds in mazePointIdentifier)
            {
                if (mazeIds[0] == ids[0] && mazeIds[1] == ids[1])
                {
                    label13.Text = $"{mazePointIdentifier.IndexOf(mazeIds)}";
                    return;
                }
            }

            label13.Text = "No maze found";
            
        }
    }

    enum ButtonState
    {
        dot,
        circle,
        endpoint
    }

    
}
