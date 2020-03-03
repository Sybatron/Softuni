let add = require('./02. Christmas Movies_Resources');
let assert = require('chai').assert;

describe('add() behavior',()=>{
    it('check if the result is 5', ()=>{
        let result = add(1,4);
        assert.equal(result,5,'The result is not 5');
    });
});