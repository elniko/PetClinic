describe('Operators', () => {

    it('Operators - 1', () => {
        var result = 0;
        for (let i = 0; i <= 3; i++) {
            result = result + i;
        }
        expect(result).toBe( _ );
    });

    it('Operators - 2', () => {
        var result = 0;
        for (let i = 0; i <= 3; i++) {
            result += i;
        }
        expect(result).toBe( _ );
    });

    it('Operators - 3', () => {
        var result = 3;
        for (let i = 0; i <= 2; i++) {
            result = result - i;
        }
        expect(result).toBe( _ );
    });

    it('Operators - 4', () => {
        var result = 3;
        for (let i = 0; i <= 2; i++) {
            result -= i;
        }
        expect(result).toBe( _ );
    });

    it('Operators - 5', () => {
        var result = 11;
        var x = 5;
        result %= x;
        expect(result).toBe( _ );
    });

    it('Operators - 6', () => {
        var result = 2 * 5 + 90 / 2 - 13;
        expect(result).toBe( _ );
    });

    it('Operators - 7', () => {
        var result = true && true || false && false;
        expect(result).toBe( _ );
    });

    it('Operators - 8', () => {
        var result = false && true || true && true;
        expect(result).toBe( _ );
    });
});
