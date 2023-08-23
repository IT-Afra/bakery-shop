import React from 'react';
import { Navigate } from 'react-router-dom';

export function RequireLogin({ children }: { children: any }): any {
  let accessToken = localStorage.getItem('access-token');
  if (accessToken) return children;
  return <Navigate to="/authentication/login" replace />;
}
