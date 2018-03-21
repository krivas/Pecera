using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pecera.Modelo
{
    class Fish : Aquaticanimal
    {
        

      

        public Fish(string url,Form formulario)
        {
            quantity++;
            if (quantity < 30)
            {
                aquaticAnimal.BackColor = Color.Transparent;
                aquaticAnimal.ImageLocation = url;
                aquaticAnimal.SizeMode = PictureBoxSizeMode.StretchImage;
                SetsFishMovement();
                positioning(formulario);
            }
        }

        private void positioning(Form form)
        {
            
            int FormWidth= Convert.ToInt32( form.Size.Width.ToString());
            int FormHeight = Convert.ToInt32(form.Size.Height.ToString());
            aquaticAnimal.Parent=form;
            aquaticAnimal.Top = rnd.Next(200, FormHeight - 100);
            aquaticAnimal.Left = rnd.Next(0, FormWidth - 100);
           
        }

       

        public void SetsFishMovement()
        {
            if (aquaticAnimal.ImageLocation.Equals(@"Resources\Dorys.png"))
            {
                initializeDirection("DiagonalUp");  
             
            }
           
            else if (aquaticAnimal.ImageLocation.Equals(@"Resources\tiburon adulto.png"))
            {
                initializeDirection("right");
               
            }
           
          
            else if (aquaticAnimal.ImageLocation.Equals(@"Resources\Nemo.png"))
            {

                initializeDirection("up");

            }
            

            else if (aquaticAnimal.ImageLocation.Equals(@"Resources\tiburon hembra.png"))
            {
                initializeDirection("left");  
            }
         
           
            
        }

       


            

        


       
    }
}
