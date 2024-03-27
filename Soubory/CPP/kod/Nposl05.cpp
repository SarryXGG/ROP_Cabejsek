#include <iostream>
#include <vector>
#include <random>

using namespace std;

int main() {
    int n;
    cout << "Zadejte pocet prvku posloupnosti: ";
    cin >> n;

    vector<double> posloupnost(n);

    // Inicializace generátoru náhodných čísel
    random_device rd;
    mt19937 gen(rd());
    uniform_real_distribution<> dis(-5.0, 19.999); // Interval <-5;20)

    // Naplnění posloupnosti náhodnými čísly
    for (int i = 0; i < n; ++i) {
        posloupnost[i] = dis(gen);
    }

    // Součet prvků v intervalu <3;7> a počet prvků mimo tento interval
    double soucet_v_intervalu = 0;
    int pocet_mimo_intervalu = 0;
    double minimalni_cislo = posloupnost[0]; // Předpokládáme, že první prvek je minimální

    for (double cislo : posloupnost) {
        if (cislo >= 3 && cislo <= 7) {
            soucet_v_intervalu += cislo;
        }
        else {
            ++pocet_mimo_intervalu;
        }
        if (cislo < minimalni_cislo) {
            minimalni_cislo = cislo;
        }
    }

    // Výpis výsledků
    cout << "Soucet prvku v intervalu <3;7>: " << soucet_v_intervalu << endl;
    cout << "Pocet prvku mimo interval <3;7>: " << pocet_mimo_intervalu << endl;
    cout << "Minimalni cislo: " << minimalni_cislo << endl;

    return 0;
}
