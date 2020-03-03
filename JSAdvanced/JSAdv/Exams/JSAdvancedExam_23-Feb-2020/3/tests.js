let Parser = require("./solution.js");
let assert = require("chai").assert;

describe("Parser behavior", () => {

    let parser;
    beforeEach(() => {
        parser = new Parser('[ {"Nancy":"architect"},{"John":"developer"},{"Kate": "HR"} ]');
    })

    describe('Creation of a class', () => {
        it('Parse JSON, creates empty log array, and creates addToLog function', () => {
            assert.deepEqual(parser._data.length, 3, 'Length of _data is not 3');
            assert.deepEqual(parser._log.length, 0, 'Length of _log is not 0');
            assert.typeOf(parser._addToLog, 'function', '_addToLog is not a function');
        })
    })

    describe('Recieving data', () => {
        it('recieve data array and add 1 log', () => {
            let dataArray = parser.data;
            assert.typeOf(dataArray, 'Array');
            assert.equal(dataArray.length, 3, 'The length of the recieved dataArray is not 3');
            assert.deepEqual(parser._log.length, 1, 'The legth of _log is not 1');
            assert.deepEqual(parser._log[0], '0: getData', 'The log is not getData');
        })
    })

    //TODO print() function tests
    describe('Print behavior', () => {
        describe('Prints the data in this format id|name|position', () => {
            it('removed entry case', () => {
                parser.removeEntry('Kate');
                assert.deepEqual(parser._log.length, 1, 'The length of _log must be 1');
                assert.deepEqual(parser._log[0], '0: removeEntry', 'The log[0] must be "0: removeEntry"');

                assert.deepEqual(parser.print(),
`id|name|position
0|Nancy|architect
1|John|developer`, 'The result is not the same');

                assert.deepEqual(parser._log.length, 2, 'The length of _log must be 2');
                assert.deepEqual(parser._log[1], '1: print', 'The log[1] must be 0: print');

            })
            it('not removed entry case', () => {
                assert.deepEqual(parser.print(),
`id|name|position
0|Nancy|architect
1|John|developer
2|Kate|HR`, 'The result is not the same');

                assert.deepEqual(parser._log.length, 1, 'The length of _log must be 2');
                assert.deepEqual(parser._log[0], '0: print', 'The log[0] must be 0: print');
            })

        })
    })

    describe('Adding entries to the data', () => {
        describe('recieves string with entries', () => {
            it('parse them and add them to _data', () => {
                parser.addEntries("Steven:tech-support Edd:administrator");
                assert.deepEqual(parser._data.length, 5, 'Length of _data is not 5');
                assert.deepEqual(parser._log.length, 1, 'Length of _log is not 1');
                assert.deepEqual(parser._log[0], '0: addEntries', 'The log is not addEntries');
            })
        })
    })


    describe('Remove entry', () => {
        it('existing entry case', () => {
            parser.removeEntry("Kate");
            assert.deepEqual(parser._data.filter(x => x.hasOwnProperty("deleted")).length, 1, 'The length of _data with "deleted" property should be 1');
            assert.deepEqual(parser._log.length, 1, 'The length of _log should be 1');
            assert.deepEqual(parser._log[0], '0: removeEntry', 'The log must be removeEntry');
        })
        it('not existing entry case', () => {
            assert.throws(() => {
                parser.removeEntry("Gosho")
            }, Error, "There is no such entry!");
        })
    })

    describe('_addTolLog behavior', () => {
        it('add log to _log', () => {
            parser._addToLog('testLog');
            assert.deepEqual(parser._log[0], '0: testLog', 'There is not a log "0: testLog" in _log');
        })
    })
})