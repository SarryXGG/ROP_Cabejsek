#include <iostream>
#include <cmath> // pro funkci abs()

using namespace std;

int main() {
    int d, n;

    // Načtení celých čísel d a n
    cout << "Zadejte cele cislo d: ";
    cin >> d;
    cout << "Zadejte pocet prvku posloupnosti: ";
    cin >> n;

    // Inicializace proměnných pro prvek s nejmenší vzdáleností k d
    int nejblizsi_prvek;
    int nejmensi_vzdalenost = INT_MAX;

    // Načtení prvků posloupnosti a nalezení prvku s nejmenší vzdáleností k d
    cout << "Zadejte " << n << " prvku posloupnosti:\n";
    for (int i = 0; i < n; ++i) {
        int prvek;
        cin >> prvek;

        // Výpočet vzdálenosti mezi prvkem a číslem d
        int vzdalenost = abs(prvek - d);

        // Pokud je vzdálenost menší než dosavadní nejmenší vzdálenost, aktualizujeme nejblíže ležící prvek
        if (vzdalenost < nejmensi_vzdalenost) {
            nejblizsi_prvek = prvek;
            nejmensi_vzdalenost = vzdalenost;
        }
    }

    // Výpis nejblíže ležícího prvku k číslu d
    cout << "Prvek posloupnosti, ktery se nejvice blizi cislu " << d << ", je: " << nejblizsi_prvek << endl;

    return 0;
}
