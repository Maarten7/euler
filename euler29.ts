var powers = new Set<number>();

for (var a: number = 2; a <= 100; a++){
  for (var b: number = 2; b <= 100; b++){
    powers.add(a**b);
  }
}

console.log(powers.size);
