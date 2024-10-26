import { User } from "./user.model";

export class LoginResponse {
    public user: User = new User();
    public token: string = '';
    constructor() {}
}