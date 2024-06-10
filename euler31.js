var coins = [200, 100, 50, 20, 10, 5, 2, 1];
function leastCoins(amount, cantUse, coinVector) {
    if (cantUse === void 0) { cantUse = []; }
    if (coinVector === void 0) { coinVector = []; }
    var numberOfCoin;
    var rest;
    for (var _i = 0, coins_1 = coins; _i < coins_1.length; _i++) {
        var coin = coins_1[_i];
        if (coin > amount) {
            continue;
        }
        else if (cantUse.indexOf(coin) > -1) {
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
function reduce(coinVector, prevReduce) {
    if (prevReduce === void 0) { prevReduce = 0; }
    for (var i = 0; i < coinVector.length; i++) {
        var coin = coinVector[i][0];
        var numberOfCoin = coinVector[i][1];
        if (coin == 1) {
            continue;
        }
        if (numberOfCoin > 0) {
            coinVector[i][1]--;
            return [coinVector, coin + prevReduce, coin];
        }
    }
}
var total;
var count = 0;
for (var i200 = 0; i200 <= 1; i200++) {
    for (var i100 = 0; i100 <= 2; i100++) {
        for (var i50 = 0; i50 <= 4; i50++) {
            for (var i20 = 0; i20 <= 10; i20++) {
                for (var i10 = 0; i10 <= 20; i10++) {
                    for (var i5 = 0; i5 <= 40; i5++) {
                        for (var i2 = 0; i2 <= 100; i2++) {
                            for (var i1 = 0; i1 <= 200; i1++) {
                                total = i200 * 200 + i100 * 100 + i50 * 50 + i20 * 20 + i10 * 10 + i5 * 5 + i2 * 2 + i1 * 1;
                                if (total == 200) {
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
