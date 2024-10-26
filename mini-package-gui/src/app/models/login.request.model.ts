export class LoginRequest {
    username: string = '';
    email: string = '';
    password: string = '';
    role: string = '';
    isGuest: boolean = false;
    loginType: string = 'Normal'
    constructor() {}
}
