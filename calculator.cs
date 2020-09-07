using System;
using System.Glabalization;

namespace Calculator{
  public class Calculator{
     public Calculator(){}
     private double Resultado = 0.00;
     public static double soma(double[] paramsToCalc){
            double resultado = 0.00;
          for(int i = 0; i < paramsToCalc.Lenght; i++){
            Resultado += paramsToCalc[i];
          }
        return Resultado;
     }
     
     override string ToString(){
        return Resultado.toString("F2", CultureInfo.InvariantCulture);
     }
  }

}
