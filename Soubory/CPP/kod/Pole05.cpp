#include <iostream>
#include <cstdlib> // pro funkce rand()

using namespace std;

int main() {
    // Deklarace konstanty pro velikost pole
    const int velikost_pole = 20;

    // Deklarace pole pro 20 náhodných reálných čísel
    double P[velikost_pole];

    // Naplnění pole náhodnými reálnými čísly z intervalu <0;50)
    cout << "Vygenerovane pole P:\n";
    for (int i = 0; i < velikost_pole; ++i) {
        P[i] = (rand() / (RAND_MAX + 1.0)) * 50; // generování náhodného čísla z intervalu <0;50)
        cout << P[i] << " ";
    }
    cout << endl;

    // Nalezení maxima a minima v poli
    double maximum = P[0];
    double minimum = P[0];
    int index_max = 0;
    int index_min = 0;

    for (int i = 1; i < velikost_pole; ++i) {
        if (P[i] > maximum) {
            maximum = P[i];
            index_max = i;
        }
        if (P[i] < minimum) {
            minimum = P[i];
            index_min = i;
        }
    }

    // Výměna maximálního a minimálního prvku v poli
    double temp = P[index_max];
    P[index_max] = P[index_min];
    P[index_min] = temp;

    // Výpis změněného pole
    cout << "\nZmenene pole P po vymene maxima a minima:\n";
    for (int i = 0; i < velikost_pole; ++i) {
        cout << P[i] << " ";
    }
    cout << endl;

    return 0;
}
