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
            Gl.glColor3d(1.0, 0.0, 0.0);
            Gl.glPointSize(5.0f);
            Gl.glRotated(10 * elapsedTime, 0, 0, 1);
            Gl.glBegin(Gl.GL_POLYGON);
            {

                
               
                Gl.glVertex3d(-0.25, 0.5, 0);//TOP LEFT
               
                Gl.glVertex3d(0.25, 0.5, 0);//TOP RIGHT
               
                Gl.glVertex3d(0.5, 0, 0);//RIGHT SIDE
                
                Gl.glVertex3d(0.25, -0.5, 0);//BOTTOM RIGHT
              
                Gl.glVertex3d(-.25, -0.5, 0);//BOTTOM LEFT
             
                Gl.glVertex3d(-0.5, 0, 0);//LEFT SIDE
                
               

            }
            Gl.glEnd();
            Gl.glFinish();

            _openGLControl.Refresh();
        }
    }

}
