using System;  

 
 

class Program  

{  
    enum Temperatue {Celsius, Fahrenheit, Kelvin};  
    enum Length {Inch, Feet, Yard};  
    enum Time {Seconds, Minutes, Hours};  

    static void Main(String[] args)  

    {  
            bool done = false;  
            Temperatue Celsisus = Temperatue.Celsius;  
            Temperatue Fahrenheit = Temperatue.Fahrenheit;  
            Temperatue Kelvin = Temperatue.Kelvin;  

        while(!done){  

            Console.WriteLine("What type of conversion you want to perform: ");  
            Console.WriteLine("1: Temperatue");  
            Console.WriteLine("2: Length");  
            Console.WriteLine("3: Time");  
            Console.WriteLine("4: Exit"); 

            Console.Write("Your choice: ");  
            int opCode = int.Parse(Console.ReadLine());  
            Console.WriteLine();  

 
            if(opCode >= 1 && opCode <= 4)  

            {  
                switch(opCode)  
                {  
                    case 1:  
                    Console.WriteLine("You chose TemperatureUnit");        
                    break;  

                    case 2:  
                    Console.WriteLine("You chose Length");  
                    break;  

                    case 3:  
                    Console.WriteLine("You chose Time");  
                    break;  

                    case 4:  
                    Console.WriteLine("Good bye!");  
                    break;  

                    default:  
                    Console.WriteLine("Invalid choice");  
                    break;  
                }

            }  

        }  


        static void ConvertTemperatureUnitScale()  
        {  

                    // Add ReadLine to get original Temp scale  

                    Console.WriteLine("What TemperatureUnit scale are you converting from: ");                      
                    Console.WriteLine("1: Celsius");  
                    Console.WriteLine("2: Fahrenheit");  
                    Console.WriteLine("3: Kelvin"); 

                    int scaleCodeFrom = int.Parse(Console.ReadLine());  
 
                   // Add ReadLine to get the orginal Temp Num  


                   Console.WriteLine("What temparture number are you converting from: ");  
                   float fromTempNum = float.Parse(Console.ReadLine());   

                    // Add ReadLine to get target Temp scale  

 
 

                    Console.WriteLine("What TemperatureUnit scale are you converting to: ");                      
                    Console.WriteLine("1: Celsius");  
                    Console.WriteLine("2: Fahrenheit");  
                    Console.WriteLine("3: Kelvin");  

                    int scaleCodeTo = int.Parse(Console.ReadLine());  
                    float toTempNum = 0;  

   
                    // Call appropriate conversion function     
 

                    if(scaleCodeFrom >= 1 && scaleCodeFrom <= 3 && scaleCodeTo >= 1 && scaleCodeTo <= 3 )  
                    {  

                             if(scaleCodeFrom == 1 && scaleCodeTo == 2)  
                             {  
                                    // #2  

                                    (scaleCodeTo, toTempNum) = FromCelsiusToKelvin(fromTempNum);                                      

                              }  
                                Console.WriteLine($"The conversion is from {scaleCodeFrom} {tempNum} to {scaleCodeTo} {tempNum}"); 

                              else if (scaleCodeFrom == 1 && scaleCodeTo == 3)  
                              {  
                                    (scaleCodeTo, toTempNum) = FromCelsiusToFahrenheit(fromTempNum);   
                               }  

                              Console.WriteLine($"The conversion is from {scaleCodeFrom} {tempNum} to {scaleCodeTo} {tempNum}");  

 
                              else if (scaleCodeFrom == 2 && scaleCodeTo == 1)  
                              {  
                                   (scaleCodeTo, toTempNum) = FromFahrenheitToCelsius(fromTempNum);   
                               }  

                              Console.WriteLine($"The conversion is from {scaleCodeFrom} {tempNum} to {scaleCodeTo} {tempNum}"); 

                              else if (scaleCodeFrom == 2 && scaleCodeTo == 3)  

                              {  
                                   (scaleCodeTo, toTempNum) = FromFahrenheitToKelvin (fromTempNum);   
                               }  

                              Console.WriteLine($"The conversion is from {scaleCodeFrom} {tempNum} to {scaleCodeTo} {tempNum}");   

                              else if (scaleCodeFrom == 3 && scaleCodeTo == 1)  

                              {  
                                  (scaleCodeTo, toTempNum) = FromKelvinToCelsius (fromTempNum);   

                                }  

                              Console.WriteLine($"The conversion is from {scaleCodeFrom} {tempNum} to {scaleCodeTo} {tempNum}"); 

                              else if (scaleCodeFrom == 3 && scaleCodeTo == 2)  
                              {  
                                   (scaleCodeTo, toTempNum) = FromKelvinToFahrenheit (fromTempNum);   
                                }  

                              Console.WriteLine($"The conversion is from {scaleCodeFrom} {tempNum} to {scaleCodeTo} {tempNum}"); 

                              else { 
                                Console.WriteLine("Invalid choice"); 
                              } 

                    }   
        }  

        static void ConvertLength()  

        {  

                    // Add ReadLine to get original Temp scale  

                    Console.WriteLine("What Length measurement are you converting from: ");                      
                    Console.WriteLine("1: Inch");  
                    Console.WriteLine("2: Feet");  
                    Console.WriteLine("3: Yard");  

 
 

                    int lengthCodeFrom = int.Parse(Console.ReadLine());  

 
 

   

                   // Add ReadLine to get the orginal Temp Num  

 
 

                   Console.WriteLine("What measure number are you converting from: ");  

                   float fromLengthNum = float.Parse(Console.ReadLine());  

 
 
 

                    // Add ReadLine to get target Temp scale  

                    Console.WriteLine("What Length measure are you converting to: ");                      
                    Console.WriteLine("1: Inch");  
                    Console.WriteLine("2: Feet");  
                    Console.WriteLine("3: Yard");  

                    int lengthCodeTo = int.Parse(Console.ReadLine());  
                    float toLengthNum = 0;  


                    // Call appropriate conversion function     

 
 

                  if (lengthCodeFrom >= 1 && lengthCodeFrom <= 3 && lengthCodeTo >= 1 && lengthCodeTo <= 3 )  
                    {  

                             if(lengthCodeFrom == 1 && lengthCodeTo == 2)  

                             {  

                                    // #2  

                                    (lengthCodeTo, toLengthNum) = FromInchToFeet(fromLengthNum);                                      

                              }  

                              Console.WriteLine($"The conversion is from {lengthCodeFrom} {lengthNum} to {lengthCodeTo} {lengthNum}");  

                              else if (lengthCodeFrom == 1 && lengthCodeTo == 3)  
                              {  

                                   (lengthCodeTo, toLengthNum) = FromInchToYard(fromLengthNum);   
                               }  

                              Console.WriteLine($"The conversion is from {lengthCodeFrom} {lengthNum} to {lengthCodeTo} {lengthNum}");  

                              else if (lengthCodeFrom == 2 && lengthCodeTo == 1)  
                              {  

                                   (lengthCodeTo, toLengthNum) = FromFeetToInch(fromLengthNum);   
                               }  

                              Console.WriteLine($"The conversion is from {lengthCodeFrom} {lengthNum} to {lengthCodeTo} {lengthNum}"); 

                              else if (lengthCodeFrom == 2 && lengthCodeTo == 3)  
                              {  

                                   (lengthCodeTo, toLengthNum) = FromFeetToYard(fromLengthNum);   
                               }  

                              Console.WriteLine($"The conversion is from {lengthCodeFrom} {lengthNum} to {lengthCodeTo} {lengthNum}");   

                              else if (lengthCodeFrom == 3 && lengthCodeTo == 1)  
                              {  

                                   (lengthCodeTo, toLengthNum) = FromYardToInch(fromLengthNum);   
                                }  

                              Console.WriteLine($"The conversion is from {lengthCodeFrom} {lengthNum} to {lengthCodeTo} {lengthNum}"); 

                              else if (lengthCodeFrom == 3 && lengthCodeTo == 2)  
                              {  

                                   (lengthCodeTo, toLengthNum) = FromYardToFeet(fromLengthNum);   
                                }  

                              Console.WriteLine($"The conversion is from {lengthCodeFrom} {lengthNum} to {lengthCodeTo} {lengthNum}"); 

                              else { 
                                Console.WriteLine("Invalid choice"); 
                              } 
                    }   

        }  

        static void ConvertTime()  

        {  

                    // Add ReadLine to get original Temp scale  

                    Console.WriteLine("What measures of time are you converting from: ");                      
                    Console.WriteLine("1: Seconds");  
                    Console.WriteLine("2: Minutes");  
                    Console.WriteLine("3: Hours");  

                    int timeCodeFrom = int.Parse(Console.ReadLine());  
  

                   // Add ReadLine to get the orginal Temp Num  

                   Console.WriteLine("What temparture number are you converting from: ");  
                   float fromTimehNum = float.Parse(Console.ReadLine());  


                    // Add ReadLine to get target Temp scale  

                    Console.WriteLine("What TemperatureUnit scale are you converting to: ");                      
                    Console.WriteLine("1: Seconds");  
                    Console.WriteLine("2: Minutes");  
                    Console.WriteLine("3: Hours");  

                    int timeCodeTo = int.Parse(Console.ReadLine());  
                    float toTimeNum = 0;  


                    // Call appropriate conversion function     

                  if (timeCodeFrom >= 1 && timeCodeFrom <= 3 && timeCodeTo >= 1 && timeCodeTo <= 3 )  
                    {  

                             if(timeCodeFrom == 1 && timeCodeTo == 2)  

                             {  

                                    // #2  

                                    (timeCodeTo, toTimeNum) = FromSecondsToMinutes(fromTimehNum);                                      

                              }  

                              Console.WriteLine($"The conversion is from {timeCodeFrom} {tempNum} to {timeCodeTo} {tempNum}");  

                              else if (timeCodeFrom == 1 && timeCodeTo == 3)  
                              {  

                                   (timeCodeTo, toTimeNum) = FromSecondsToHours(fromTimehNum);   
                               }  

                              Console.WriteLine($"The conversion is from {timeCodeFrom} {timeNum} to {timeCodeTo} {timeNum}");  

                              else if (timeCodeFrom == 2 && timeCodeTo == 1)  
                             {  
                                   (timeCodeTo, toTimeNum) = FromMinutesToSeconds(fromTimehNum);   
                               }  

                              Console.WriteLine($"The conversion is from {timeCodeFrom} {timeNum} to {timeCodeTo} {timeNum}"); 

                              else if (timeCodeFrom == 2 && timeCodeTo == 3)  
                              {  

                                   (timeCodeTo, toTimeNum) = FromMinutesToHours(fromTimehNum);   
                               }  

                              Console.WriteLine($"The conversion is from {timeCodeFrom} {timeNum} to {timeCodeTo} {timeNum}");   

                              else if (timeCodeFrom == 3 && timeCodeTo == 1)  
                              {  

                                   (timeCodeTo, toTimeNum) = FromHoursToSeconds(fromTimehNum);   
                                }  

                              Console.WriteLine($"The conversion is from {timeCodeFrom} {timeNum} to {timeCodeTo} {timeNum}"); 

                              else if (timeCodeFrom == 3 && timeCodeTo == 2)  
                              {  

                                   (timeCodeTo, toTimeNum) = FromHoursToMinutes(fromTimehNum);   
                                }  

                              Console.WriteLine($"The conversion is from {timeCodeFrom} {timeNum} to {timeCodeTo} {timeNum}"); 

                              else { 
                                Console.WriteLine("Invalid choice"); 
                                } 

                    }   

        }  



        // update return type to tuple  

 


        // static float FromCelsiusToKelvin(float c)  

 
        // #1  

 
        static (Temperatue scaleCodeTo, float tempNum) FromCelsiusToKelvin(float c)  
        {  
            Console.WriteLine("Please insert the temperatrue in Celsius");  
            c = Convert.ToSingle(Console.ReadLine());  
            return(c + 273.15f);  

        }  


        static (Temperatue scaleCodeTo, float tempNum) FromCelsiusToFahrenheit (float c)  
        {  

           Console.WriteLine("Please insert the temperatrue in Celsius");  

            c = Convert.ToSingle(Console.ReadLine());  

            return((c*9/5)+32);  

        }  

 
 

  

        static (Temperatue scaleCodeTo, float tempNum) FromFahrenheitToCelsius (float f)  

        {  

            Console.WriteLine("Please insert the temperatrue in Fahrenheit");  

            f = Convert.ToSingle(Console.ReadLine());  

            return(5/9*(f - 32));    

        }  

 
 

       static (Temperatue scaleCodeTo, float tempNum) FromFahrenheitToKelvin (float f)  

        {  

            Console.WriteLine("Please insert the temperatrue in Fahrenheit");  

            f = Convert.ToSingle(Console.ReadLine());  

            return((f - 32)* 5/9 + 273.15f);    

        }  

 
 

        static (Temperatue scaleCodeTo, float tempNum) FromKelvinToCelsius (float k)  

        {  

            Console.WriteLine("Please insert the temperatrue in Kelvin");  

            k = Convert.ToSingle(Console.ReadLine());  

            return(k - 273.15f);    

        }  

 
 

        static (Temperatue scaleCodeTo, float tempNum) FromKelvinToFahrenheit (float k)  

        {  

            Console.WriteLine("Please insert the temperatrue in Kelvin");  

            k = Convert.ToSingle(Console.ReadLine());  

            return(1.8f * (k-273.15f) + 32);    

        }  

 
 
 

        static (Length lengthCodeTo, float lengthNum) FromInchToFeet (float i)  

        {  

            Console.WriteLine("Please insert the length in Inches");  

            i = Convert.ToSingle(Console.ReadLine());  

            return(i/12);    

        }  

 
 

        static (Length lengthCodeTo, float lengthNum) FromInchToYard (float i)  

        {  

            Console.WriteLine("Please insert the length in Inches");  

            i = Convert.ToSingle(Console.ReadLine());  

            return(i/36);    

        }  

 
 

        static (Length lengthCodeTo, float lengthNum) FromFeetToInch (float f)  

        {  

            Console.WriteLine("Please insert the length in Feets");  

            f = Convert.ToSingle(Console.ReadLine());  

            return(f*12);    

        }  

 
 

        static (Length lengthCodeTo, float lengthNum) FromFeetToYard (float f)  

        {  

            Console.WriteLine("Please insert the length in Feets");  

            f = Convert.ToSingle(Console.ReadLine());  

            return(f/12);    

        }  

 
 

        static (Length lengthCodeTo, float lengthNum) FromYardToInch (float y)  

        {  

            Console.WriteLine("Please insert the length in Yards");  

            y = Convert.ToSingle(Console.ReadLine());  

            return(y*36);    

        }  

 
 

        static (Length lengthCodeTo, float lengthNum) FromYardToFeet (float y)  

        {  

            Console.WriteLine("Please insert the length in Yards");  

            y = Convert.ToSingle(Console.ReadLine());  

            return(y*3);    

        }  

 
 

        static (Time timeCodeTo, float timeNum) FromSecondsToMinutes (float s)  

        {  

            Console.WriteLine("Please insert the time in seconds");  

            s = Convert.ToSingle(Console.ReadLine());  

            return(s/60);  

        }  

 
 

        static (Time timeCodeTo, float timeNum)  FromSecondsToHours (float s)  

        {  

            Console.WriteLine("Please insert the time in seconds");  

            s = Convert.ToSingle(Console.ReadLine());  

            return(s/3600);  

        }  

 
 

        static (Time timeCodeTo, float timeNum) FromMinutesToSeconds (float m)  

        {  

            Console.WriteLine("Please insert the time in minutes");  

            m = Convert.ToSingle(Console.ReadLine());  

            return(m*60);  

        }  

 
 

        static (Time timeCodeTo, float timeNum) FromMinutesToHours (float m)  

        {  

            Console.WriteLine("Please insert the time in minutes");  

            m = Convert.ToSingle(Console.ReadLine());  

            return(m/60);  

 
 

        }  

 
 

        static (Time timeCodeTo, float timeNum) FromHoursToSeconds (float h)  

        {  

            Console.WriteLine("Please insert the time in hours");  

            h = Convert.ToSingle(Console.ReadLine());  

            return(h*3600);  

 
 

        }  

 
 

        static (Time timeCodeTo, float timeNum) FromHoursToMinutes (float h)  

        {  

            Console.WriteLine("Please insert the time in hours");  

            h = Convert.ToSingle(Console.ReadLine());  

            return(h*60);  

 
 

        }  

    }  

 }  
