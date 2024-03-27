#include <iostream>

using namespace std;

// Funkce pro výpočet součtu všech dělitelů zadaného čísla
int soucetDelitelu(int cislo) {
    int soucet = 0;

    // Procházíme všechna čísla od 1 do daného čísla a hledáme dělitele
    for (int i = 1; i <= cislo; ++i) {
        if (cislo % i == 0) { // Pokud je i dělitelem cisla, přičteme ho k součtu
            soucet += i;
        }
    }

    return soucet;
}

int main() {
    int cislo;

    // Načtení celého kladného čísla od uživatele
    cout << "Zadejte cele kladne cislo: ";
    cin >> cislo;

    // Volání funkce soucetDelitelu a výpis výsledku
    int vysledek = soucetDelitelu(cislo);
    cout << "Soucet vsech delitelu cisla " << cislo << " je: " << vysledek << endl;

    return 0;
}
