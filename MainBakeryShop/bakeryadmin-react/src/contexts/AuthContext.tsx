import React from 'react';
import { IUserToken } from 'models/IUserToken';
import { Navigate } from 'react-router-dom';

export interface IAuthContext {
  userToken?: IUserToken;
  login: (userToken: IUserToken) => void;
  logout: () => void;
  isInRole: (roleName: string) => boolean;
}

export const AuthContext = React.createContext<IAuthContext>({
  login: (userToken: IUserToken) => {},
  logout: () => {},
  isInRole: (roleName: string) => false,
});

export function RequireLogin({ children }: { children: any }): any {
  const authContext = React.useContext(AuthContext);
  if (authContext.userToken) return children;
  return <Navigate to="/authentication/login" replace />;
}
