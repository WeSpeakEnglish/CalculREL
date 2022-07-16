/*
 * Created by SharpDevelop.
 * User: Pinus
 * Date: 26.09.2011
 * Time: 11:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CalculRel
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Delitel
	{
	public Int16 LineIS,TypeOfCalc;
	public double Devidend,U1,U2,LineFactor;
	
	public double[] E6= new double[6]  {1.0,1.5,2.2,3.3,4.7,6.8};
	public double[] E12= new double[12] {1.0,1.2,1.5,1.8,2.2,2.7,3.3,3.9,4.7,5.6,6.8,8.2};
	public double[] E24= new double[24] {1.0,1.1,1.2,1.3,1.5,1.6,1.8,2.0,2.2,2.4,2.7,3.0,3.3,3.6,3.9,4.3,4.7,5.1,5.6,6.2,6.8,7.5,8.2,9.1};
	public double[] E48= new double[48] {1.0,1.05,1.1,1.15,1.21,1.27,1.33,1.4,1.47,1.54,1.62,1.69,1.78,1.87,1.96,2.05,2.15,2.26,2.37,2.49,
		 2.61,2.74,2.87,3.01,3.16,3.32,3.48,3.65,3.83,4.02,4.22,4.42,4.64,4.87,5.11,5.36,5.62,5.9,6.19,6.49,
		 6.81,7.15,7.5,7.87,8.25,8.66,9.09,9.53};
 	public double[] E96= new double[96] {1.0,1.02,1.05,1.07,1.1,1.13,1.15,1.18,1.21,1.24,1.27,1.3,1.33,1.37,1.4,1.43,1.47,1.5,1.54,1.58,1.62,
                 1.65,1.69,1.74,1.78,1.82,1.87,1.91,1.96,2,2.05,2.1,2.15,2.21,2.26,2.32,2.37,2.43,2.49,2.55,2.61,
                 2.67,2.74,2.8,2.87,2.94,3.01,3.09,3.16,3.24,3.32,3.4,3.48,3.57,3.65,3.74,3.83,3.92,4.02,4.12,4.22,
                 4.32,4.42,4.53,4.64,4.75,4.87,4.99,5.11,5.23,5.36,5.49,5.62,5.76,5.9,6.04,6.19,6.34,6.49,6.65,6.81,
                 6.98,7.15,7.32,7.5,7.68,7.87,8.06,8.25,8.45,8.66,8.87,9.09,9.31,9.53,9.76};
 	public double[] E192= new double[192] {1,1.01,1.02,1.04,1.05,1.06,1.07,1.09,1.1,1.11,1.13,1.14,1.15,1.17,1.18,1.2,1.21,1.23,1.24,1.26,
 		 1.27,1.29,1.3,1.32,1.33,1.35,1.37,1.38,1.4,1.42,1.43,1.45,1.47,1.49,1.5,1.52,1.54,1.56,1.58,1.6,
     	 1.62,1.64,1.65,1.67,1.69,1.72,1.74,1.76,1.78,1.8,1.82,1.84,1.87,1.89,1.91,1.93,1.96,1.98,2,2.03,
  		 2.05,2.08,2.1,2.13,2.15,2.18,2.21,2.23,2.26,2.29,2.32,2.34,2.37,2.4,2.43,2.46,2.49,2.52,2.55,2.58,
  		 2.61,2.64,2.67,2.71,2.74,2.77,2.8,2.84,2.87,2.91,2.94,2.98,3.01,3.05,3.09,3.12,3.16,3.2,3.24,3.28,
	 	 3.32,3.36,3.4,3.44,3.48,3.52,3.57,3.61,3.65,3.7,3.74,3.79,3.83,3.88,3.92,3.97,4.02,4.07,4.12,4.17,
 		 4.22,4.27,4.32,4.37,4.42,4.48,4.53,4.59,4.64,4.7,4.75,4.81,4.87,4.93,4.99,5.05,5.11,5.17,5.23,5.3,
 		 5.36,5.42,5.49,5.56,5.62,5.69,5.76,5.83,5.9,5.97,6.04,6.12,6.19,6.26,6.34,6.42,6.49,6.57,6.65,6.73,
		 6.81,6.9,6.98,7.06,7.15,7.23,7.32,7.41,7.5,7.59,7.68,7.77,7.87,7.96,8.06,8.16,8.25,8.35,8.45,8.56,
		 8.66,8.76,8.87,8.98,9.09,9.19,9.31,9.42,9.53,9.65,9.76,9.88};
	public double Up_Value_i;
	public double Up_Value_j;
	public double Down_Value_i;
	public double Down_Value_j;
	public double SourceW;
	
	public Delitel(){
		LineIS = 		6;
		LineFactor=		6.8;
		Devidend = 		1.0;
		U1 = 			1.0;
		U2 = 			0.5;	
		Up_Value_i = 	1.0;
	    Up_Value_j = 	1.0;
	    Down_Value_i =	1.0;
	    Down_Value_j =	1.0;
	    SourceW = 		0.5;
	}
	 ~Delitel(){}
	 public int SetU1(double Voltage1){
	 	U1 = Voltage1;
	 	return 0;
	 }
	 public double GetU2(double Rel){
	 	U2 = U1/(Rel+1.0);
	 	return U2;	
	 }
	public int CalculateRelation(Double Relation){ // переносим сценарий из JavaScript, после возможна оптимизация
	  Int16 i =				0;
	  Int16 j =				0;
	  double min_Up =   	1.0e10;
      double min_Down = 	1.0e10;
      SourceW = 		(double)Relation;
      double Mult =			1.0e-9;
	   switch(LineIS){
 			case 6: 	LineFactor = 6.8; // последнее значение в ряде  
 	           								break;
  			case 12: 	LineFactor = 8.2;   break;
 			case 24: 	LineFactor = 9.1;   break; 
 			case 48: 	LineFactor = 9.53;  break;        
 	       	case 96: 	LineFactor = 9.76;  break;   
 			case 192: 	LineFactor = 9.88;  break;     
		 }
	  
    for(i=0;i<20;i++){
   		 if((SourceW/Mult <= LineFactor)&&(SourceW/Mult >= 1.0/LineFactor)){
    		Devidend= Mult; 
   			 break;
         }
         else{Mult *= 10.0;}
       } 	
      
    double x=Devidend*E6[0]/E6[0];
    Int16 i_Up=0,j_Up=0,i_Down=0,j_Down=0;
    
	for(i=0;i<LineIS;i++){
	for(j=0;j<LineIS;j++){
		switch(LineIS){
			case 6:  x=Devidend*E6[i]/E6[j];		break;
			case 12: x=Devidend*E12[i]/E12[j];		break;
			case 24: x=Devidend*E24[i]/E24[j];		break;
			case 48: x=Devidend*E48[i]/E48[j];		break;
			case 96: x=Devidend*E96[i]/E96[j]; 		break;
			case 192: x=Devidend*E192[i]/E192[j]; 	break;
		}
		if(x-SourceW < min_Up && x-SourceW >= 0){
				min_Up = x-SourceW;
				i_Up = i;
				j_Up = j;
			}
		if(SourceW-x < min_Down && SourceW-x >= 0){
				min_Down = SourceW-x;
				i_Down = i;
				j_Down = j;
			}

		}
	}

		switch(LineIS){
			case 6:  	Up_Value_i=Devidend*E6[i_Up]; 
	         			Up_Value_j = E6[j_Up];
	         			Down_Value_i=  Devidend*E6[i_Down]; 
	         			Down_Value_j = E6[j_Down];
	        			break;
			case 12: 	Up_Value_i=Devidend*E12[i_Up]; 
	         			Up_Value_j = E12[j_Up];
	         			Down_Value_i=  Devidend*E12[i_Down]; 
	         			Down_Value_j = E12[j_Down];
	         			break;
			case 24: 	Up_Value_i=Devidend*E24[i_Up]; 
	         			Up_Value_j = E24[j_Up];
	         			Down_Value_i=  Devidend*E24[i_Down]; 
	         			Down_Value_j = E24[j_Down];
	         			break;
			case 48: 	Up_Value_i=Devidend*E48[i_Up]; 
	         			Up_Value_j = E48[j_Up];
	         			Down_Value_i=  Devidend*E48[i_Down]; 
	         			Down_Value_j = E48[j_Down];
	         			break;    
			case 96: 	Up_Value_i=Devidend*E96[i_Up]; 
	         			Up_Value_j = E96[j_Up];
	         			Down_Value_i=  Devidend*E96[i_Down]; 
	         			Down_Value_j = E96[j_Down];
	         			break;     
			case 192: 	Up_Value_i=Devidend*E192[i_Up]; 
	          			Up_Value_j = E192[j_Up];
	          			Down_Value_i=  Devidend*E192[i_Down]; 
	          			Down_Value_j = E192[j_Down];
	          			break; 
					} 
	
	 return 0;
	 }
	}
}
