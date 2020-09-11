using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
  public  class Perceptron
    {
      
      int[,] VectorsForEducation;
      int[,] VectorsForAnswer;

      public Perceptron(int[,] VectorsForEducation,int[,] VectorsForAnswer)
      {
          this.VectorsForEducation = VectorsForEducation;
          this.VectorsForAnswer = VectorsForAnswer;
          
        }

      public void educate(int numOfIter, Double Koef)
      {
          for (int i = 0; i < numOfIter; i++) {
              for (int i = 0; i < VectorsForEducation.; i++)
              {


              }
          
          }
      }


        public double sigmoid(double x){
            return 1/(1+Math.Exp(x));
        }

    }
}
