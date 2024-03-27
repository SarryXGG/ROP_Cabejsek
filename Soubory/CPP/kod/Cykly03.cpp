#include <iostream>

int soucin(int a, int b) {
    int vysledek = 0;
    for (int i = 0; i < b; ++i) {
        vysledek += a;
    }
    return vysledek;
}

int main() {
    int a, b;
    std::cout << "Zadejte dve prirozena cisla (a, b): ";
    std::cin >> a >> b;

    int vysledek = soucin(a, b);

    std::cout << "Soucin cisel " << a << " a " << b << " je: " << vysledek << std::endl;

    return 0;
}
