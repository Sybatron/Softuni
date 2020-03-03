function gladiatorExpenses(losts, helmetPrice, swordPrice, shieldPrice, armorPrice) {
    let expenses = 0;
    for (let i = 2; i <= losts; i++) {
        if (i % 12 === 0) {
            expenses += armorPrice;
            expenses += shieldPrice;
            expenses += helmetPrice;
            expenses += swordPrice;
        } else if (i % 6 === 0) {
            expenses += shieldPrice;
            expenses += helmetPrice;
            expenses += swordPrice;
        } else if (i % 2 === 0) {
            expenses += helmetPrice;
        } else if (i % 3 === 0) {
            expenses += swordPrice;
        }
    }

    expenses=expenses.toFixed(2);
    console.log(`Gladiator expenses: ${expenses} aureus`);
}