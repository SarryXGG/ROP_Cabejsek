#include <iostream>

using namespace std;

// Funkce pro výpočet aritmetického průměru ze tří reálných čísel
double prumer3(double cislo1, double cislo2, double cislo3) {
    return (cislo1 + cislo2 + cislo3) / 3.0;
}

// Funkce pro zjištění, zda zadané celé číslo je liché
bool jeLiche(int cislo) {
    return cislo % 2 != 0;
}

// Funkce pro zjištění, zda zadaný znak je písmeno
bool jePismeno(char znak) {
    return (znak >= 'a' && znak <= 'z') || (znak >= 'A' && znak <= 'Z');
}

int main() {
    // Testování funkce prumer3
    double prumer = prumer3(3.5, 4.8, 6.2);
    cout << "Prumer ze tri realnych cisel: " << prumer << endl;

    // Testování funkce jeLiche
    int licheCislo = 7;
    int sudeCislo = 10;
    cout << licheCislo << " je liche: " << (jeLiche(licheCislo) ? "ano" : "ne") << endl;
    cout << sudeCislo << " je liche: " << (jeLiche(sudeCislo) ? "ano" : "ne") << endl;

    // Testování funkce jePismeno
    char pismeno = 'a';
    char cislice = '5';
    cout << pismeno << " je pismeno: " << (jePismeno(pismeno) ? "ano" : "ne") << endl;
    cout << cislice << " je pismeno: " << (jePismeno(cislice) ? "ano" : "ne") << endl;

    return 0;
}
