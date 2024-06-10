from math import factorial

def factorial_cov(args):
    summ = 0
    for i in range(len(args)):
        print(f"{i}! *", args[-1-i])
        summ += args[-1-i] * factorial(i)
    print(summ)
    numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
    ret = ""

    for z in args:
        ret += str(numbers.pop(z))

    return ret

print(factorial_cov([2, 6, 6, 2, 5, 1, 2, 1, 1, 0]))


