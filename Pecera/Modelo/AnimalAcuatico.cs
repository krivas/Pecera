using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pecera.Modelo
{
    abstract class Aquaticanimal
    {

        protected PictureBox aquaticAnimal=new PictureBox();
        public static int quantity;
         private void moverDiagonalArriba(Form form)
        {
            aquaticAnimal.Parent = form;
            aquaticAnimal.Left += 1;
            aquaticAnimal.Top -= 1;
        }

         private void moverDiagonalAbajo(Form form)
        {
            aquaticAnimal.Parent = form;
            aquaticAnimal.Left += 1;
            aquaticAnimal.Top += 1;
        }

         private void moverDerecho(Form form)
        {
              aquaticAnimal.Parent = form;
             aquaticAnimal.Left += 1;
        }

         private void moverIzquierda(Form form)
        {
            aquaticAnimal.Parent = form;
            aquaticAnimal.Left -= 1;
        }

         private void moverArriba(Form form)
        {
            aquaticAnimal.Parent = form;
            aquaticAnimal.Top -= 1;
        }

         private void moverAbajo(Form form)
        {
            aquaticAnimal.Parent = form;
            aquaticAnimal.Top += 1;
        }

         public void mover(Form form)
         {
             if (aquaticAnimal.ImageLocation.Equals(@"C:\Users\Kevin\Desktop\Construccion\Pecera\Pecera\Resources\Dorys.png"))
             {
                 moverDiagonalArriba(form);
                 return;
             }
             else if (aquaticAnimal.ImageLocation.Equals(@"C:\Users\Kevin\Desktop\Construccion\Pecera\Pecera\Resources\Pez hembra.png"))
             {
                 moverIzquierda(form);
                 return;
             }
             else if (aquaticAnimal.ImageLocation.Equals(@"C:\Users\Kevin\Desktop\Construccion\Pecera\Pecera\Resources\Tiburon adulto.png"))
             {
                 moverDerecho(form);
                 return;
             }
             else if (aquaticAnimal.ImageLocation.Equals(@"C:\Users\Kevin\Desktop\Construccion\Pecera\Pecera\Resources\Tiburon macho.png"))
             {
                 moverDerecho(form);
                 return;
             }
             else if (aquaticAnimal.ImageLocation.Equals(@"C:\Users\Kevin\Desktop\Construccion\Pecera\Pecera\Resources\Tiburon bebe hembra.png"))
             {
                 moverIzquierda(form);
                 return;
             }
             else if (aquaticAnimal.ImageLocation.Equals(@"C:\Users\Kevin\Desktop\Construccion\Pecera\Pecera\Resources\Nemo.png"))
             {
                 moverArriba(form);
                 return;
             }
             else if (aquaticAnimal.ImageLocation.Equals(@"C:\Users\Kevin\Desktop\Construccion\Pecera\Pecera\Resources\tiburon macho.png"))
             {
                 moverAbajo(form);
                 return;
             }

             else if (aquaticAnimal.ImageLocation.Equals(@"C:\Users\Kevin\Desktop\Construccion\Pecera\Pecera\Resources\tiburon adulto.png"))
             {
                 moverDerecho(form);
                 return;
             }
             else if (aquaticAnimal.ImageLocation.Equals(@"C:\Users\Kevin\Desktop\Construccion\Pecera\Pecera\Resources\Pez macho.png"))
             {
                 moverDiagonalAbajo(form);
                 return;
             }

             else if (aquaticAnimal.ImageLocation.Equals(@"C:\Users\Kevin\Desktop\Construccion\Pecera\Pecera\Resources\tiburon hembra.png"))
             {
                 moverIzquierda(form);
                 return;
             }
         }

       

        
    }
}
