describe('Equality', () => {

    it('Equality - 1', () => {
        expect(3 + 7 == 10).toBe( _ );
    });

    it('Equality - 2', () => {
        expect(3 + 7 == "10").toBe( _ );
    });

    it('Equality - 3', () => {
        expect(3 + 7 === 10).toBe( _ );
    });

    it('Equality - 4', () => {
        expect(3 + 7 === "10").toBe( _ );
    });

    it('Equality - 5', () => {
        expect("3" + "7" == "37").toBe( _ );
    });

    it('Equality - 6', () => {
        expect("3" + "7" == 37).toBe( _ );
    });

    it('Equality - 7', () => {
        expect("3" + "7" === "37").toBe( _ );
    });

    it('"3" + "7" === 37', () => {
        expect("3" + "7" === 37).toBe( _ );
    });

    it('"3" + 7 == "37"', () => {
        expect("3" + 7 == "37").toBe( _ );
    });

    it('"3" + 7 === 37', () => {
        expect("3" + 7 === 37).toBe( _ );
    });

});