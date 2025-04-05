#include <iostream>
using namespace std;

int main()
{
	//Mensaje de bienvenida
	cout << "Hola :) Este programa 2 unidad 2" << "\n";
	
	//Se declaran los numeros que se sumaran (Pueden ser decimales)
	float SUELDO, aum, nsue;
	
	//Se pide el primer numero
	cout << "Por favor ingrese el sueldo:  ";
	
	//Se asigna el primer valor a SUELDO
	cin >> SUELDO;
	
if (SUELDO < 400000.00)
      {
       aum = SUELDO * 0.15;
       nsue = SUELDO + aum;
	
}
    cout << "El nuevo sueldo es:  "<<nsue ;
    //Se muestra resultado
    
    return 0;
}
