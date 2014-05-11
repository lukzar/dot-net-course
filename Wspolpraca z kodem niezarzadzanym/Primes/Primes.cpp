#include "stdafx.h"

#include <cmath>
#include "Primes.h"

int IsPrime(int number) {
    if (number < 2) {
        return 0;
    }

    unsigned int limit = static_cast<unsigned>(ceil(sqrt(static_cast<float>(number))));

    for (unsigned int i = 2; i < limit; i++) {
        if (number % i == 0) {
            return 0;
        }
    }

    return 1;
}
