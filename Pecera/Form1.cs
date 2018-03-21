using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pecera.Modelo;
using System.Threading;
using System.Collections;
namespace Pecera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
        }
        Fish[] fish = new Fish[8];
        ArrayList fishList = new ArrayList();
        private void timer1_Tick(object sender, EventArgs e)
        {
            int quantity = fishList.Count;
            
            Fish[] fishes = new Fish[fishList.Count];
            fishes = (Fish[])fishList.ToArray(typeof(Fish));
            for (int x = 0; x <fishList.Count ; x++)
            {
                fishes[x].move(this);
            }


            for (int w = 0; w < quantity; w++)
            {
                for (int j = w + 1; j < quantity; j++)
                {
                    fishes[w].crash(fishes[j], this,fishList); 
                }
            }

           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string [] images = new string[18];
            images[0] = @"Resources\Dorys.png";
            images[1] = @"Resources\Nemo.png";
           
            images[2] = @"Resources\tiburon hembra.png";
            images[3] = @"Resources\tiburon adulto.png";
            images[4] = @"Resources\Dorys.png";
            images[5] = @"Resources\Nemo.png";

            images[6] = @"Resources\tiburon hembra.png";
            images[7] = @"Resources\tiburon adulto.png";
            images[8] = @"Resources\Dorys.png";
            images[9] = @"Resources\Nemo.png";

            images[10] = @"Resources\tiburon hembra.png";
            images[11] = @"Resources\tiburon adulto.png";

            images[12] = @"Resources\tiburon hembra.png";
            images[13] = @"Resources\tiburon adulto.png";
            images[14] = @"Resources\tiburon hembra.png";
            images[15] = @"Resources\tiburon adulto.png";
            images[16] = @"Resources\tiburon hembra.png";
            images[17] = @"Resources\tiburon adulto.png";
          
                  
               for (int x =0;x<8;x++)
                {
                    Thread.Sleep(200);
                    
                    fishList.Add(new Fish(images[x],this));
                         
                   
                
                }

               
             
                timer1.Enabled = true;
                
               
               
                
            
         
        }

      

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }

   
    }
}
