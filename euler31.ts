var coins: number[] = [200, 100, 50, 20, 10, 5, 2, 1];

function leastCoins(amount: number, cantUse: number[] = [], coinVector: [number, number][] = []): [number, number][]{
  let numberOfCoin: number;
  let rest: number;
  
  for (let coin of coins){
    if (coin > amount) {
      continue;
    }

    else if (cantUse.indexOf(coin) > -1){
      continue;
    }

    else {
      numberOfCoin = Math.floor(amount / coin);
      rest = amount % coin;
      coinVector.push([coin, numberOfCoin]);  
    }

    if (rest == 0) {
      return coinVector;
    }
    return leastCoins(rest, cantUse, coinVector);
  }
}

function reduce(coinVector: [number, number][], prevReduce: number = 0): [[number, number][], number, number]{
  for (let i: number = 0; i < coinVector.length; i++){

    let coin: number = coinVector[i][0];
    let numberOfCoin: number = coinVector[i][1];

    if (coin == 1){
      continue;
    }

    if (numberOfCoin > 0){
      coinVector[i][1]--;
      return [coinVector, coin + prevReduce, coin];
    }
  }
}
let total: number;
let count: number = 0;
for (let i200: number = 0; i200 <= 1; i200++){
  for (let i100: number = 0; i100 <= 2; i100++){
    for (let i50: number = 0; i50 <= 4; i50++){
      for (let i20: number = 0; i20 <= 10; i20++){
        for (let i10: number = 0; i10 <= 20; i10++){
          for (let i5: number = 0; i5 <= 40; i5++){
            for (let i2: number = 0; i2 <= 100; i2++){
              for (let i1: number = 0; i1 <= 200; i1++){
                total = i200 * 200 + i100 * 100 + i50 * 50 + i20 * 20 + i10 * 10 + i5 * 5 + i2 * 2 + i1 * 1
                if (total == 200){
                  count++;
                }
              }
            }
          }
        }
      }
    }
  }
}

console.log(count);
