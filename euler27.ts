//global prime array
var primes: number[] = [2, 3, 5, 7];

// quadric function given by the problem 
function quadratic(n: number, a: number, b: number): number {
  return n**2 + a*n + b;
}

function generatePrimes(upperLimit: number): void {
  for (var i = primes[primes.length -1]; i <= upperLimit; i = i + 2){
    if (isNewPrime(i)) {
     primes.push(i);
    }
  }
}

function isNewPrime(n: number): boolean {
  for (var prime of primes) {
    if (prime >= Math.ceil(Math.sqrt(n))) {
      return true;
    }
    if (n % prime == 0) {
      return false;
    }
  }
  return true;
}

function isPrime(n: number): boolean{
  // can only check for primeness if inside of prime domain 
  if (n > primes[primes.length -1]){
    generatePrimes(n);
  }

  if (primes.indexOf(n) > -1) {
    return true;
  }
}
var max_a: number = -999;
var max_b: number = 0;
var max_n: number = 0;

for (var a: number = -999; a < 1000; a = a + 2){
  for (var b: number = 0; b <= 1000; b++){

    if (!(isPrime(b))) {
      continue;
    }

    var n: number = 0;
    while (isPrime(quadratic(n, a, b))) {
      n++;
    }
    if (n > max_n) {
      max_n = n;
      max_a = a;
      max_b = b;
    }
  }
}
console.log(max_a * max_b);
