#include <iostream>
#include <cstdio>

using namespace std;

int main() {
    int x;

    // Načtení čísla od uživatele
    cout << "Zadejte cislo x: ";
    cin >> x;

    // Výpis zprávy pomocí printf
    printf("Cislo %d je %s.\n", x, (x % 2 == 0) ? "sude" : "liche");

    return 0;
}
