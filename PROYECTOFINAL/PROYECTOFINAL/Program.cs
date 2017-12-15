using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTOFINAL
{
    // "PROGRAMA QUE INDICA SI ERES MAYOR O MENOR DE EDAD, SEXO Y SI PUEDES VOTAR O NO"
    // NOMBRE: LUIS ALFREDO | APELLIDOS: TUSEN SILVERIO | MATRICULA: 12-EISN-1-082 | SECCION: 0908
    class Program
    {
        static void Main(string[] args)
        {
            {        
                int edad;
                string nombre;
                string sexo;
                Console.WriteLine("\n\n'PROGRAMA QUE INDICA SI ERES MAYOR O MENOR DE EDAD, SEXO Y SI PUEDES VOTAR O NO' ");

                        Console.WriteLine("\nIntroduce tu Nombre\n");
                        nombre = Console.ReadLine();

                        Console.WriteLine("\nIntroduce tu Edad\n");
                        edad = int.Parse(Console.ReadLine());
                        do
                        {
                        } while ((edad <= 0));
                        Console.WriteLine("\nIntroduce tu Sexo (F o M)\n");
                        sexo = Console.ReadLine();
                        do
                        {
                        } while (!((sexo.Equals("f") || sexo.Equals("m"))));
                        if (sexo.Equals("m") && edad >= 18)
                        {
                            Console.WriteLine(nombre);
                            Console.WriteLine("\nEres Hombre");
                            Console.WriteLine("\nEres mayor de edad y puedes votar.");
                            Console.WriteLine("\n\nESTUDIANTE: LUIS ALFREDO TUSEN SILVERIO");
                            Console.WriteLine("\nMATRICULA: 12-EISN-1-082");
                            Console.Read();
                        }
                        else
                        {
                            if (sexo.Equals("f") && edad >= 18)
                            {
                                Console.WriteLine(nombre);
                                Console.WriteLine("\nEres Mujer");
                                Console.WriteLine("\nEres mayor de edad y puedes votar.");
                                Console.WriteLine("\n\nESTUDIANTE: LUIS ALFREDO TUSEN SILVERIO");
                                Console.WriteLine("\nMATRICULA: 12-EISN-1-082");
                                Console.Read();
                            }
                            else
                            {
                                if (sexo.Equals("m") && edad < 18)
                                {
                                    Console.WriteLine(nombre);
                                    Console.WriteLine("\nEres Hombre");
                                    Console.WriteLine("\nEres menor de edad y no puedes votar.");
                                    Console.WriteLine("\n\nESTUDIANTE: LUIS ALFREDO TUSEN SILVERIO");
                                    Console.WriteLine("\nMATRICULA: 12-EISN-1-082");
                                    Console.Read();
                                }
                                else
                                {
                                    if (sexo.Equals("f") && edad < 18)
                                    {
                                        Console.WriteLine(nombre);
                                        Console.WriteLine("\nEres Mujer");
                                        Console.WriteLine("\nEres menor de edad y no puedes votar.");
                                        Console.WriteLine("\n\nESTUDIANTE: LUIS ALFREDO TUSEN SILVERIO");
                                        Console.WriteLine("\nMATRICULA: 12-EISN-1-082");
                                        Console.Read();
                                    }



                                }
                            }
                        }



                    }

                }

            }
        }

    







   