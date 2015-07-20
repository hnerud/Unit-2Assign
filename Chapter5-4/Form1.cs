using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;

namespace StartingGraphics
{
    public partial class Form1 : Form
    {
        FastLoop _fastLoop;
        bool _fullscreen = false;

        public Form1()
        {
            _fastLoop = new FastLoop(GameLoop);

            InitializeComponent();
            _openGLControl.InitializeContexts();


            if (_fullscreen)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
        }

        void GameLoop(double elapsedTime)
        {
            Gl.glClearColor(0.0f, 0.0f, 0.0f, 1.0f);
            
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glPointSize(5.0f);
            Gl.glRotated(10 * elapsedTime, 1, 0, 0);
            Gl.glBegin(Gl.GL_TRIANGLE_STRIP);
            {

                //TRIANGLE 1
                Gl.glColor4d(1.0, 0.0, 0.0, 0.5);
                Gl.glVertex3d(-0.5, 0, 0);//BOTTOM LEFT
                Gl.glColor3d(0.0, 1.0, 0.0);
                Gl.glVertex3d(-0.5, 1, 0);//TOP LEFT
                Gl.glColor3d(0.0, 0.0, 1.0);
                Gl.glVertex3d(1, 0, 0);//BOTTOM RIGHT

                //TRIANGLE2

                Gl.glColor3d(0.5, 0.0, 0.5);
                Gl.glVertex3d(1, 1.0, 0);//TOP RIGHT

            }
            Gl.glEnd();
            Gl.glFinish();

            _openGLControl.Refresh();
        }
    }

}
