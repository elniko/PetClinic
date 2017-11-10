describe('Prototype chain', () =>{

    var father = {
        b: 3,
        c: 4
    };

    var child = Object.create(father);
    child.a = 1;
    child.b = 2;

    it("Prototype chain - 1", () =>{
        expect(child.hasOwnProperty('a')).toBe( _ );
        expect(child.hasOwnProperty('b')).toBe( _ );
    });

    it("Prototype chain - 2", () => {
        expect(child.a).toBe( _ );
        expect(child.b).toBe( _ );
    });

    it("Prototype chain - 3", () => {
        delete child.b;
        expect(child.b).toBe( _ );
    });

    it("Prototype chain - 4", () => {
        expect(child.hasOwnProperty('c')).toBe( _ );
    });

    it("Prototype chain - 5", () => {
        expect(child.c).toBe( _ );
    });

    it("Prototype chain - 6", () => {
        expect(child.d).toBe( _ );
    });


});