describe('Objects', () => {

    it('Objects - 1', () => {
        var result = {};
        expect(typeof(result)).toBe( _ );
    });

    it('Objects - 2', () => {
        var person = {
            // _
        };
        expect(person.name).toBe('Jean Paul');
        expect(person.age).toBe(51);
    });

    it('Objects - 3', () => {
        var person = {};
        Object.assign( person, _ );
        expect(person.name).toBe('Jean Paul');
        expect(person.age).toBe(51);
    });

    it('Objects - 4', () => {
        var person = {};
        // _
        // _
        expect(person.name).toBe('Jean Paul');
        expect(person['phone-number']).toBe('0145254515');
    });

    it('Objects - 5', () => {
        var person = {
            name: "Jean Paul",
            age: 25,
            toString: function() {
                return _ ;
            }
        };
        expect(person.toString()).toBe('My name is Jean Paul and I am 25 years old');
    });

    it('Objects - 5', () => {
        var person = {
            firstname: "Jon",
            lastname: "Snow",
            knows: {},
            // _
        };
        expect(person.fullname).toBe('Jon Snow');
        person.firstname = "Aegon"
        expect(person.fullname).toBe('Aegon Snow');
    });

});
