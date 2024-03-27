#include <iostream>

using namespace std;

long long soucinCisel(int a, int b) {
    long long soucin = 1; // Začínáme součinem 1, aby první číslo přispělo k výsledku

    for (int i = a; i <= b; ++i) {
        soucin *= i;
    }

    return soucin;
}

int main() {
    int a, b;
    cout << "Zadejte dve cela cisla (a, b): ";
    cin >> a >> b;

    if (b < a) {
        cout << "Chyba: Druhe cislo (b) musi byt vetsi nez prvni cislo (a)." << endl;
        return 1;
    }

    long long vysledek = soucinCisel(a, b);

    cout << "Soucin vsech cisel od " << a << " do " << b << " je: " << vysledek << endl;

    return 0;
}
