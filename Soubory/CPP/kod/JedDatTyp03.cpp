#include <iostream>

int main() {
    int cislo;
    bool obsahuje_delitelne_6 = false;

    std::cout << "Zadejte posloupnost celych nezapornych cisel zakoncenou zapornym cislem:" << std::endl;

    // Načítání čísel a testování dělitelnosti
    while (true) {
        std::cin >> cislo;
        if (cislo < 0) // Pokud je číslo záporné, ukončíme cyklus
            break;
        if (cislo % 6 == 0) {
            obsahuje_delitelne_6 = true;
            break; // Pokud nalezneme číslo dělitelné 6, nemusíme dále testovat
        }
    }

    if (obsahuje_delitelne_6)
        std::cout << "Posloupnost obsahuje cislo delitelne 6." << std::endl;
    else
        std::cout << "Posloupnost neobsahuje cislo delitelne 6." << std::endl;

    return 0;
}
