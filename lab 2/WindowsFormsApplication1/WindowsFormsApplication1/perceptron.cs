using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
  public  class Perceptron
    {
      
      double[,] VectorsForEducation;
      double[,] VectorsForEducationAnswer;
      double[,] weights;
      int numOfNeyron;
      int numOfWeight;


      public Perceptron(double[,] VectorsForEducation, double[,] VectorsForEducationAnswer)
      {
          this.VectorsForEducation = VectorsForEducation;
          this.VectorsForEducationAnswer = VectorsForEducationAnswer;
          numOfNeyron = VectorsForEducationAnswer.GetLength(0);
          numOfWeight = VectorsForEducation.GetLength(1);  
          inicialaizeWeights();
        }
      public void inicialaizeWeights(){
         Random rand = new Random();
         weights = new double[numOfWeight,numOfNeyron];
         for (int n = 0; n < numOfNeyron; n++)
             for (int w = 0; w < numOfNeyron; w++)
          {
              weights[n,w] = rand.NextDouble();
          }
      }

      public void educate(int numOfIter, Double Koef)
      {   //cicle of education
          for (int e = 0; e < numOfIter; e++) {
             
                  //cicle of neyron
                  double[] answer = new double[numOfNeyron];
                  for (int n = 0; n < numOfNeyron; n++)
                  {
                     // answer[n] = reLU(VectorsForEducation[n],weights[n]);

                  }
                    
          }
      }


        public double reLU(double[] x,double[] w){
            double sumW = 0;
            for (int i = 0; i < numOfWeight; i++)
                sumW += x[i] * w[i];
            return Math.Max(0, sumW);
        }

    }
}
