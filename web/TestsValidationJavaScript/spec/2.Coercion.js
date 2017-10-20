describe('Coercion', () => {

    it('Coercion - 1', () => {
        expect(3 + 7 === 10).toBe( _ );
    });

    it('Coercion - 2', () => {
        expect(3 + 7 == "10").toBe( _ );
    });

    it('Coercion - 3', () => {
        expect(1 == true).toBe( _ );
    });

    it('Coercion - 4', () => {
        expect(new Date(3) + 7 == "10").toBe( _ );
    });

    it('Coercion - 5', () => {
        expect("3" + 7 == "37").toBe( _ );
    });

    it('Coercion - 6', () => {
        expect(["3"] + ["7"] == 37).toBe( _ );
    });

    it('Coercion - 7', () => {
        expect(typeof (/3/ + 7)).toBe( _ );
    });

    it('Coercion - 8', () => {
        expect(1 + true === "1true").toBe( _ );
    });

    it('Coercion - 9', () => {
        expect(+"3" + +"7" == "37").toBe( _ );
    });

    it('Coercion - 10', () => {
        expect("3" + "7" == 37).toBe( _ );
    });
});
