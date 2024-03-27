#include <iostream>

using namespace std;

int main() {
    int a = 150; // První prvek posloupnosti
    int b = 200; // Poslední prvek posloupnosti
    int n = b - a + 1; // Počet prvků posloupnosti
    int soucet = (n * (a + b)) / 2; // Výpočet součtu

    cout << "Soucet vsech celych cisel od 150 do 200 vcetne je: " << soucet << endl;

    return 0;
}
