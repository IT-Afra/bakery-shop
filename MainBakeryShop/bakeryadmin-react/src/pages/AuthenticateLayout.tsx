import React from 'react'
import { Outlet } from 'react-router-dom'

type Props = {}

const AuthenticateLayout = (props: Props) => {
  return (
    <div>
        <h1>This is AuthenticateLayout</h1>

        <Outlet />

    </div>
  )
}

export default AuthenticateLayout