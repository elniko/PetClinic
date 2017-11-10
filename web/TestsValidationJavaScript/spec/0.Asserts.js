describe('About Jasmine assertions : ', () => {

    it('you should know what will satisfy the toBeTruthy assertion', () => {
       expect( _ ).toBeTruthy();
    });

    it('you should know what will satisfy the toBeFalsy assertion', () => {
        expect( _ ).toBeFalsy();
    });

    it('you should know what will satisfy the toBe assertion', () => {
        expect( _ ).toBe('3');
    });

    it('you should know what will satisfy the not assertion', () => {
        expect( _ ).not.toBe('3');
    });

})