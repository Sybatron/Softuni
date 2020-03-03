let SkiResort = require('./solution');
let assert = require('chai').assert;


//*Instantiation with one parameter - a string representing the ski resort name,
//*and an additional properties called "voters"(number with value 0 by default) and
//*"hotels" ( empty array by default).

describe('SkiResort', function () {
    let skiResort;
    //* rN = Resort name

    rN = 'Softuni Hotel';
    beforeEach(function () {
        skiResort = new SkiResort(rN);
    })

    let stringifyCompare = (a, b) => assert.deepEqual(JSON.stringify(a), JSON.stringify(b));

    describe('Instantiation with one parameter', () => {
        it('When created with string should', () => {
            assert.deepEqual(skiResort.name, 'a');
            assert.deepEqual(skiResort.voters, 0);
            assert.deepEqual(stringifyCompare(skiResort.hotels, []));
        })
    })

    describe('bestHotel method', () => {
        it('no voters case', () => {
                assert.deepEqual(skiResort.bestHotel, 'No votes yet');
            }),
            it('voters case', () => {
                //TODO
                let best = skiResort.hotels.reduce((a, b) => a.points > b.points ? a : b);
                assert.deepEqual(skiResort.bestHotel, `Best hotel is ${best.name} with grade ${best.points}. Available beds: ${best.beds}`);
            })
    })

    describe('Build hotel', ()=>{
        it('should throw if there is no name', ()=>{
            
        })
    })
});