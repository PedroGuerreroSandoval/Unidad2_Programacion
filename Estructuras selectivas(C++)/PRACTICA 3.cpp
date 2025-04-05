#include <iostream>

using namespace std;


int main()
{
	//Mensaje de bienvenida
	cout << "Hola :) Este programa 1 Unidad 2" << "\n";
	
	//Se declaran los numeros que se sumaran (pueden ser decimales)
	float NOTA;
	
	//Se pide el primer numero
	cout << "Por favor ingrese la calificacion: ";
	
	//Se asigna el primer valor a NOTA
	cin >> NOTA;
	
	if (NOTA>=3.0)
	            cout << " Aprobado" ;
	    else
	            cout<<"Reprobado";
	            
	//Se muestra el resultado
	
	
	return 0;
}
