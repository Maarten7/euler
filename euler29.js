var powers = new Set();
for (var a = 2; a <= 100; a++) {
    for (var b = 2; b <= 100; b++) {
        powers.add(Math.pow(a, b));
    }
}
console.log(powers.size);
