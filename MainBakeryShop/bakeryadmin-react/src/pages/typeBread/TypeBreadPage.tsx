import React from 'react'
import { Spin, Row, Col, Table } from 'antd'
import { ITypeBread } from '../../models/ITypeBread'
import type { ColumnsType } from 'antd/es/table';
import axios from 'axios'

type Props = {}

const TypeBreadPage = (props: Props) => {
  const [isSpinning, setIsSpinning] = React.useState(true)
  const [typeBreads, setTypeBreads] = React.useState<ITypeBread[]>([])

  const getTypeBreads = () => {
    axios.get<ITypeBread[]>('https://localhost:7239/api/typeBread')
      .then(function (response) {
        setTypeBreads(response.data)
      })
      .catch(function (error) {
        // handle error
        console.log(error);
      })
      .finally(function () {
        setIsSpinning(false)
      });
  }

  React.useEffect(() => {
    getTypeBreads();
  }, []);

  const columns: ColumnsType<ITypeBread> = [
    {
      title: 'عنوان',
      dataIndex: 'name',
    },
    {
      title: 'وضعیت',
      dataIndex: 'isActive',
      render: (isActive: boolean) => isActive ? "فعال" : "غیرفعال"
    },
  ]

  return (
    <Spin spinning={isSpinning}>
      <Row>
        <Col span={5}>
          انواع نان
        </Col>
      </Row>
      <Table columns={columns} dataSource={typeBreads} />
    </Spin>
  )
}

export default TypeBreadPage