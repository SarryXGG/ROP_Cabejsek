#include <iostream>
#include <vector>

using namespace std;

int main() {
    vector<int> posloupnost;
    int cislo;

    // Načtení posloupnosti nenulových čísel od uživatele
    cout << "Zadejte posloupnost nenulovych cisel zakoncenou nulou: ";
    while (cin >> cislo && cislo != 0) {
        posloupnost.push_back(cislo);
    }

    // Kontrola, zda byla načtena alespoň jedna hodnota
    if (posloupnost.empty()) {
        cout << "Posloupnost neobsahuje zadne hodnoty." << endl;
        return 1;
    }

    // Vyhledání maxima a minima v posloupnosti a jejich pořadí
    int maximum = posloupnost[0];
    int minimum = posloupnost[0];
    int pozice_maxima = 1; // Pořadí prvního výskytu maxima
    int pozice_minima = 1; // Pořadí prvního výskytu minima
    int pocet_maxim = 1;    // Počet výskytů maxima
    int pocet_minim = 1;    // Počet výskytů minima

    for (size_t i = 1; i < posloupnost.size(); ++i) {
        if (posloupnost[i] > maximum) {
            maximum = posloupnost[i];
            pozice_maxima = i + 1; // Pořadí začíná od 1, nikoli od 0
            pocet_maxim = 1;
        }
        else if (posloupnost[i] == maximum) {
            pozice_maxima = i + 1; // Aktualizace pořadí posledního výskytu maxima
            pocet_maxim++;
        }

        if (posloupnost[i] < minimum) {
            minimum = posloupnost[i];
            pozice_minima = i + 1; // Pořadí začíná od 1, nikoli od 0
            pocet_minim = 1;
        }
        else if (posloupnost[i] == minimum) {
            pozice_minima = i + 1; // Aktualizace pořadí prvního výskytu minima
            pocet_minim++;
        }
    }

    // Výpis maximální hodnoty a jejích charakteristik
    cout << "Maximum posloupnosti: " << maximum << ", na pozici: " << pozice_maxima << ", vyskytuje se " << pocet_maxim << "x." << endl;

    // Výpis minimální hodnoty a jejích charakteristik
    cout << "Minimum posloupnosti: " << minimum << ", na pozici: " << pozice_minima << ", vyskytuje se " << pocet_minim << "x." << endl;

    return 0;
}
