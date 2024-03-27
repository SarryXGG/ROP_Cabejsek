#include <iostream>

using namespace std;

// Funkce pro vypsání zadaného počtu hvězdiček na řádek
void hvezdicky(int pocet) {
    for (int i = 0; i < pocet; i++) {
        cout << "*";
    }
    cout << endl;
}

// Funkce pro vypsání zadaného počtu zadaného znaku na řádek
void znaky(char znak, int pocet) {
    for (int i = 0; i < pocet; i++) {
        cout << znak;
    }
    cout << endl;
}

// Funkce pro vypsání zadaného počtu hvězdiček na zadaný počet řádků
void radkyHvezdicek(int pocet, int radky) {
    for (int i = 0; i < radky; i++) {
        hvezdicky(pocet);
    }
}

int main() {
    // Volání funkcí v sekvenci za sebou
    hvezdicky(5); // Vypíše 5 hvězdiček na řádek
    znaky('@', 3); // Vypíše 3 zavináče na řádek
    radkyHvezdicek(4, 3); // Vypíše 4 hvězdičky na 3 řádky

    return 0;
}
