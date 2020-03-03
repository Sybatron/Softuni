function registerHeroes(array) {
    class Hero {
        constructor(name, level, items) {
            this.name = name;
            this.level = Number(level);
            this.items = items.split(', ');
        }
    }

    let heroes = [];
    array.forEach(element => {
        let reg = new RegExp(/(?<name>[A-Za-z]{1,}) \/ (?<level>\d{1,}) \/ (?<items>([A-Za-z]{1,}(, ){0,1}){1,})/);
        match = element.match(reg).groups;

        heroes.push(new Hero(match.name, match.level, match.items));
    });

    console.log(JSON.stringify(heroes));
}

registerHeroes([
    'Isacc / 25 / Apple, GravityGun',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara'
]);